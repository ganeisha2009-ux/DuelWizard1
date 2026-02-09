
using System.Threading.Channels;

Wizard wizardA = new Wizard("dukun palsu", 20);
Wizard wizardB = new Wizard("dukun asli", 40);

Console.WriteLine("Permainan Dimulai \n");
wizardA.ShowStats();
wizardB.ShowStats();

//wizardA.Attack(wizardB);
//wizardB.Attack(wizardA);
//wizardA.Heal();
//wizardA.Attack(wizardB);

string pilihan;
while (wizardA.Energy > 0 && wizardB.Energy > 0)
{
    Console.WriteLine($"1. {wizardA.Name} menyerang {wizardB.Name}");
    Console.WriteLine($"2. {wizardB.Name} menyerang {wizardA.Name}");
    Console.WriteLine($"3. {wizardA.Name} melakukan heal");
    Console.WriteLine($"4. {wizardB.Name} melakukan heal");

    Console.WriteLine("\nMasukkan pilihan mu (1/2/3/4) : ");
    pilihan = Console.ReadLine();

    if (pilihan == "1")
    {
        wizardA.Attack(wizardB);
    }
    else if (pilihan == "1")
    {
        wizardB.Attack(wizardA);
    }
    else if (pilihan == "3")
    {
        wizardA.Heal();
    }
    else if (pilihan == "4")
    {
        wizardB.Heal();
    }
    else
    {
        Console.WriteLine("Pilihan tidak valid");
    }

}




Console.WriteLine("Permainan Berakhir");
Console.WriteLine("Statistik Akhir");
wizardA.ShowStats();
wizardB.ShowStats();

if (wizardA.Energy > wizardA.Energy)
{
    Console.WriteLine($"{wizardA.Name} memenangkan duel!!");

}
else
{
    Console.WriteLine($"{wizardA.Name} memenangkan duel!!");
}

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

    public void Heal()
    {
        Energy += 5;

        if(Energy <= 100)
        {
            
            Console.WriteLine($"{Name} melakukan heal! Energi meningkat menjadi {Energy}");
        }
        else
        {
            Energy = 100;
            Console.WriteLine("Sudah mencapai energi maximum");
        }
    }
}



