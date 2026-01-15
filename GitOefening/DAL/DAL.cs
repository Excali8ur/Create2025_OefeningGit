using Microsoft.Data.SqlClient; // Replace System.Data.SqlClient with Microsoft.Data.SqlClient
using OverervingDieren.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverervingDieren.DAL
{
    public class Dal
    {
        private static string connectionString;
        private string catalog;

        /// <summary>
        /// Bij het aanmaken van de data access layer moet de naam van de database meegegeven worden.
        /// De DAL is specifiek geschreven voor huisdieren, maar de naam van de database kan verschillen.
        /// </summary>
        /// <param name="catalog">Naam van de database waar connectie mee gemaakt wordt</param>
        public Dal(string catalog)
        {
            this.catalog = catalog;
            connectionString = $"Data Source=.;Initial Catalog={catalog};Integrated Security=True; TrustServerCertificate=True";
        }

        /// <summary>
        /// Haalt alle dieren op, met de naam van hun soort
        /// Zonder eigenschappen van eigenaren
        /// </summary>
        /// <returns></returns>
        public List<Dier> GetAlleDieren()
        {
            List<Dier> dieren = new List<Dier>();

            string query = "SELECT * FROM DIER";

            //Connectie maken met database en openen
            using var connection = new SqlConnection(connectionString); // Gebruik Microsoft.Data.SqlClient ipv System.Data.SqlClient
            connection.Open();

            //Querie uitvoeren
            using var command = new SqlCommand(query, connection);
            using var reader = command.ExecuteReader();

            //Resultaten uitlezen
            //De 'while' lus gaat door totdat er geen records (dieren) meer zijn
            while (reader.Read())
            {
                string soort = reader["Soort"].ToString();
                string naam = reader["Naam"].ToString();
                string geluid = reader["Geluid"].ToString();
                int aantalPoten = Convert.ToInt32(reader["AantalPoten"]);
                bool heeftVacht = Convert.ToBoolean(reader["HeeftVacht"]);
                bool kanVliegen = Convert.ToBoolean(reader["kanVliegen"]);

                bool draagtHoed = Convert.ToBoolean(reader["draagtHoed"]);
                bool heeftHuisje = Convert.ToBoolean(reader["heeftHuisje"]);

                //Dier aanmaken. Klasse Dier is abstract, dus kan niet direct een object van gemaakt worden
                Dier dier = MaakDierAan(soort, naam, geluid, aantalPoten, heeftVacht, kanVliegen, draagtHoed, heeftHuisje);

                dieren.Add(dier);
            }
            return dieren;
        }

        public List<Eigenaar> GetAlleEigenaren() 
        {                         
            List<Eigenaar> eigenaren = new List<Eigenaar>();

            string query = "SELECT * FROM EIGENAAR";
            //Connectie maken met database en openen
            using var connection = new SqlConnection(connectionString); // Gebruik Microsoft.Data.SqlClient ipv System.Data.SqlClient
            connection.Open();
            //Querie uitvoeren
            using var command = new SqlCommand(query, connection);
            using var reader = command.ExecuteReader();
            //Resultaten uitlezen
            //De 'while' lus gaat door totdat er geen records (dieren) meer zijn
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["eigenaarid"]);
                string naam = reader["naam"].ToString();
                string adres = reader["adres"].ToString();
                string telefoonnummer = reader["telefoonnummer"].ToString();
                eigenaren.Add(new Eigenaar(id, naam, adres, telefoonnummer));
            }
            return eigenaren;
        }

        public List<Dier> GetAlleDierenVanEigenaar(int eigenaarId)
        {
            List<Dier> dieren = new List<Dier>();
            string query = "SELECT *, SOORT.soort AS soort FROM DIER JOIN SOORT ON DIER.soortid = SOORT.soortid WHERE eigenaar = @eigenaarid";

                       
            //Connectie maken met database en openen
            using var connection = new SqlConnection(connectionString); // Gebruik Microsoft.Data.SqlClient ipv System.Data.SqlClient
            connection.Open();
            //Querie uitvoeren
            using var command = new SqlCommand(query, connection);
            //Parameter toevoegen om SQL-injectie te voorkomen
            command.Parameters.AddWithValue("@eigenaarid", eigenaarId);
            
            using var reader = command.ExecuteReader();
            //Resultaten uitlezen
            //De 'while' lus gaat door totdat er geen records (dieren) meer zijn
            while (reader.Read())
            {
                string soort = reader["Soort"].ToString();
                string naam = reader["Naam"].ToString();
                string geluid = reader["Geluid"].ToString();
                int aantalPoten = Convert.ToInt32(reader["AantalPoten"]);
                bool heeftVacht = Convert.ToBoolean(reader["HeeftVacht"]);
                bool kanVliegen = Convert.ToBoolean(reader["kanVliegen"]);
                bool draagtHoed = Convert.ToBoolean(reader["draagtHoed"]);
                bool heeftHuisje = Convert.ToBoolean(reader["heeftHuisje"]);

                //Dier aanmaken. Klasse Dier is abstract, dus kan niet direct een object van gemaakt worden
                Dier dier = MaakDierAan(soort, naam, geluid, aantalPoten, heeftVacht, kanVliegen, draagtHoed, heeftHuisje);
                dieren.Add(dier);
            }
            return dieren;
        }

        public List<string> GetEigenaarGegevensViaId(int eigenaarId)
        {
            List<string> eigenaarGegevens = new List<string>();
            string query = "SELECT * FROM EIGENAAR WHERE EigenaarId = @EigenaarId";

            //Connectie maken met database en openen
            using var connection = new SqlConnection(connectionString); // Gebruik Microsoft.Data.SqlClient ipv System.Data.SqlClient
            connection.Open();
            //Querie uitvoeren
            using var command = new SqlCommand(query, connection);
            //Parameter toevoegen om SQL-injectie te voorkomen
            command.Parameters.AddWithValue("@EigenaarId", eigenaarId);
            using var reader = command.ExecuteReader();
            //Resultaten uitlezen
            //De 'while' lus gaat door totdat er geen records (eigenaren) meer zijn.
            //Zou in dit geval maar 1 eigenaren moeten zijn
            while (reader.Read())
            {
                string naam = reader["Naam"].ToString();
                string adres = reader["Adres"].ToString();
                string telefoonnummer = reader["Telefoonnummer"].ToString();

                eigenaarGegevens.Add(naam);
                eigenaarGegevens.Add(adres);
                eigenaarGegevens.Add(telefoonnummer);
            }

            return eigenaarGegevens;
        }

        public void VoegDierToeAanEigenaar(int eigenaarId, Dier dier)
        {
            List<string> eigenaarGegevens = new List<string>();

            //Eerst controleren of het dier al bestaat bij de eigenaren
            string checkQuery = "SELECT COUNT(*) FROM DIER WHERE Naam = @Naam AND Eigenaar = @EigenaarId";
            using var checkConnection = new SqlConnection(connectionString);
            checkConnection.Open();
            using var checkCommand = new SqlCommand(checkQuery, checkConnection);
            checkCommand.Parameters.AddWithValue("@Naam", dier.naam);
            checkCommand.Parameters.AddWithValue("@EigenaarId", eigenaarId);
            int count = (int)checkCommand.ExecuteScalar();
            checkConnection.Close();
            if (count > 0)
            {
                //Dier bestaat al, dus een foutmelding geven
                throw new Exception("Dit dier bestaat al voor deze eigenaren.");
            }

            //Volgende ID opzoeken
            string chipnrQuery = "SELECT MAX(ChipNr) FROM DIER";
            using var chipConnection = new SqlConnection(connectionString);
            chipConnection.Open();
            using var chipCommand = new SqlCommand(chipnrQuery, chipConnection);
            object result = chipCommand.ExecuteScalar();
            int nextChipNr = (result != DBNull.Value) ? Convert.ToInt32(result) + 1 : 1;

            //SoortID opzoeken bij de naam
            string soortIdQuery = "SELECT SoortId FROM SOORT WHERE Soort = @SoortNaam";
            using var soortConnection = new SqlConnection(connectionString);
            soortConnection.Open();
            using var soortCommand = new SqlCommand(soortIdQuery, soortConnection);
            //Met "GetType().Name" de naam van de klasse (soort dier) ophalen
            soortCommand.Parameters.AddWithValue("@SoortNaam", dier.GetType().Name);
            int soortId = (int)soortCommand.ExecuteScalar();
            soortConnection.Close();

            //Als het dier nog niet bestaat, komt er geen foutmelding en gaat de code verder met het toevoegen aan de database
            
            string query = "INSERT INTO DIER (ChipNr, SoortId, Naam, Geluid, AantalPoten, HeeftVacht, kanVliegen, draagtHoed, heeftHuisje, Eigenaar) " +
                "VALUES (@ChipNr, @Soort, @Naam, @Geluid, @AantalPoten, @HeeftVacht, @kanVliegen, @draagtHoed, @heeftHuisje, @EigenaarId)";

            using var connection = new SqlConnection(connectionString);
            connection.Open();
            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ChipNr", nextChipNr);
            command.Parameters.AddWithValue("@EigenaarId", eigenaarId);            
            command.Parameters.AddWithValue("@Soort", soortId);

            command.Parameters.AddWithValue("@Naam", dier.naam);
            command.Parameters.AddWithValue("@Geluid", dier.geluid);
            command.Parameters.AddWithValue("@AantalPoten", dier.aantalPoten);
            command.Parameters.AddWithValue("@HeeftVacht", dier.heeftVacht);
            command.Parameters.AddWithValue("@kanVliegen", dier.kanVliegen);
            //Specifieke eigenschappen voor bepaalde dieren
            if (dier is Vogelbekdier)
            {
                command.Parameters.AddWithValue("@draagtHoed", ((Vogelbekdier)dier).draagtHoed);
            }
            else
            {
                command.Parameters.AddWithValue("@draagtHoed", false);
            }
            if (dier is Slak)
            {
                command.Parameters.AddWithValue("@heeftHuisje", ((Slak)dier).heeftHuisje);
            }
            else
            { 
                command.Parameters.AddWithValue("@heeftHuisje", false);
            }

            //Query uitvoeren (dit is een INSERT, dus geen resultaten verwachten)
            command.ExecuteNonQuery();
            connection.Close();            
        }

        /// <summary>
        /// Hulpmethode om het juiste dier-object aan te maken op basis van het soort
        /// </summary>
        /// <returns>Type Dier, maar gevuld met het juiste concrete dier</returns>
        /// <exception cref="Exception"></exception>
        private Dier MaakDierAan(string soort, string naam, string geluid, int aantalPoten, bool heeftVacht, bool kanVliegen,
            bool draagtHoed, bool heeftHuisje)
        {
            Dier dier = null;
            //Juiste dierklasse aanmaken op basis van de soort
            switch (soort)
            {
                case "Beer":
                    dier = new Beer(naam, geluid, aantalPoten, heeftVacht, kanVliegen);
                    break;
                case "Dolfijn":
                    dier = new Dolfijn(naam, geluid, aantalPoten, heeftVacht, kanVliegen);
                    break;
                case "Eekhoorn":
                    dier = new Eekhoorn(naam, geluid, aantalPoten, heeftVacht, kanVliegen);
                    break;
                case "Hond":
                    dier = new Hond(naam, geluid, aantalPoten, heeftVacht, kanVliegen);
                    break;
                case "Kangoeroe":
                    dier = new Kangoeroe(naam, geluid, aantalPoten, heeftVacht, kanVliegen);
                    break;
                case "Kat":
                    dier = new Kat(naam, geluid, aantalPoten, heeftVacht, kanVliegen);
                    break;
                case "Kikker":
                    dier = new Kikker(naam, geluid, aantalPoten, heeftVacht, kanVliegen);
                    break;
                case "Octopus":
                    dier = new Octopus(naam, geluid, aantalPoten, heeftVacht, kanVliegen);
                    break;
                case "Paard":
                    dier = new Paard(naam, geluid, aantalPoten, heeftVacht, kanVliegen);
                    break;
                case "Papegaai":
                    dier = new Papegaai(naam, geluid, aantalPoten, heeftVacht, kanVliegen);
                    break;
                case "Slak":
                    dier = new Slak(naam, geluid, aantalPoten, heeftVacht, kanVliegen, heeftHuisje);
                    break;
                case "Vlinder":
                    dier = new Vlinder(naam, geluid, aantalPoten, heeftVacht, kanVliegen);
                    break;
                case "Vogel":
                    dier = new Vogel(naam, geluid, aantalPoten, heeftVacht, kanVliegen);
                    break;
                case "Vogelbekdier":
                    dier = new Vogelbekdier(naam, geluid, aantalPoten, heeftVacht, kanVliegen, draagtHoed);
                    break;
                default:
                    //Als het dier niet herkend wordt, een foutmelding geven
                    throw new Exception("Onbekende diersoort");
            }
            return dier;
        }
    }
}