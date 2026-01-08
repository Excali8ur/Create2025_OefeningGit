namespace OverervingDieren.Model;

internal class Beer : Dier
{
    protected bool houVanZalm;
    private string ReactieOpZalm;
    
    public Beer(string naam, string geluid, int aantalPoten, bool heeftVacht, bool houVanZalm) 
        : base(naam, geluid, aantalPoten, heeftVacht) //Constructor van de basisklasse
    {
        this.houVanZalm = houVanZalm;
    }

    public string houIkVanZalm()
    {
        if(houVanZalm == true)
        {
            ReactieOpZalm = "Heel erg";
        }
        else
        {
            ReactieOpZalm = "Helemaal NIET";
        }
        return $"{naam} houd  {ReactieOpZalm} van zalm";
    }

//hoihoi
