
Wizard wizardA = new Wizard("dukun palsu", 20);
Wizard wizardB = new Wizard("dukun asli", 40);

Console.WriteLine("Permainan Dimulai \n");
wizardA.ShowStats();
wizardB.ShowStats();

wizardA.Attack(wizardB);
wizardB.Attack(wizardA);
wizardA.Attack(wizardB);

Console.WriteLine("Permainan Berakhir");

public class Wizard

{
    public String Name;
    public int Energy;
    public int Damage;

    public Wizard(String name, int damage)
    {
        Name = name;
        Energy = 100;
        Damage = damage;
    }

    public void ShowStats()
    {
        Console.WriteLine("Statistik Wizard");
        Console.WriteLine($"Nama: {Name}, Energi: {Energy} \n");
    }

    public void Attack(Wizard wizardLawanObj)
    {
        //mengurangi enargi wizardLawanObj sebesar damage
        wizardLawanObj.Energy -= Damage;
        Console.WriteLine($"{Name} menyerang {wizardLawanObj.Name}");
        Console.WriteLine($"Sisa energi {wizardLawanObj.Name} adalah {wizardLawanObj.Energy} \n");

    }
}