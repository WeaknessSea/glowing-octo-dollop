/*using System.Runtime.InteropServices;

Random rand = new Random(); // random generator

//int random_numb = rand.Next(1, 101); 

//Item zenith = new Item("Zenith", 122, "Lazy");
//Console.WriteLine($"This is my sword! Take a look: {zenith.Prefix} {zenith.name}");

//while (zenith.Prefix != "Legendary") {
//    zenith.Reforge("Lazy");
  //  //Console.WriteLine($"{zenith.Prefix} {zenith.name}");using System.Runtime.InteropServices;

Random rand = new Random(); // random generator

//int random_numb = rand.Next(1, 101); 

//Item zenith = new Item("Zenith", 122, "Lazy");
//Console.WriteLine($"This is my sword! Take a look: {zenith.Prefix} {zenith.name}");

//while (zenith.Prefix != "Legendary") {
//    zenith.Reforge("Lazy");
  //  //Console.WriteLine($"{zenith.Prefix} {zenith.name}");
//}
//Console.WriteLine($"{zenith.Prefix} {zenith.name}");
/*
Inventory my_inv = new Inventory(5);
Item terrablade1 = new Item("Terra Blade", 122, "Legendary");
Item zenith1 = new Item("Zenith",3000,"Broken");

my_inv.Remove_item(zenith1);
my_inv.Add_item(terrablade1);


// shelf world yea very nice username
//Console.WriteLine(myItems);
public class Item
{
    public string name;
    public int BaseDamage;
    public string Prefix;
// null uyarini sikem senin rahat birak beni
    public Item(string name, int BaseDamage, string Prefix)
    {
        this.name = name;
        this.BaseDamage = BaseDamage;
        this.Prefix = Prefix;
    }
    public override string ToString()
    {
        return $"Name: {this.name}, BaseDamage: {this.BaseDamage}";
    }

List<string> prefixes = ["lazy","Legendary","weak","strong","keen","damaged"];
    public string Reforge(string Prefix)
    {
        Random rand = new Random();
        int randomIndex = rand.Next(0,prefixes.Count);
        this.Prefix = prefixes[randomIndex];  
        Console.WriteLine($"Reforged! New reforge is {this.Prefix} {this.name}.");
        return Prefix;
    }
}

public class Inventory
{
    List<string> myItems = [];
    public int inv_slot;

    public Inventory(int inv_slot)
    {
        this.inv_slot = inv_slot;

    }
    
    public void Add_item(Item item)
    {
         myItems.Add(item.name);
         Console.WriteLine($"{item.name} has added to the inventory!");
         
    }
    
    public void Remove_item(Item item)
   {
        myItems.Remove(item.name);
        Console.WriteLine($"{item.name} has removed from the inventory.");
   }

    

    public void ShowInventory()
    {
        Console.WriteLine(myItems);
    }    
    
    
    
}
*/


/*F
List<string> Player_inv = [];



public class Player

{
    public string name;
    public int hp;
    public int InventorySlot;
    
    public Player (string name, int hp, int InventorySlot){
        this.name = name;
        this.hp = hp;
        this.InventorySlot = InventorySlot;
    }

    public void AddItems(Item targetItem)
    {
        Player_inv // I have to create an Item class

    }


}

public class Item
{
  public string Weapon_name;
  public int dmg;
  public string prefix;

  public Item(string Weapon_name, int dmg, string prefix)
  {
    this.Weapon_name = Weapon_name;
    this.dmg = dmg;
    this.prefix = prefix;
  }
List<string> prefixes = ["lazy","Legendary","weak","strong","keen","damaged"];
  public string Reforging(string prefix)
  {
    
  }
}
using System.Runtime.InteropServices;

Random rand = new Random(); // random generator
*/
//int random_numb = rand.Next(1, 101); 

//Item zenith = new Item("Zenith", 122, "Lazy");
//Console.WriteLine($"This is my sword! Take a look: {zenith.Prefix} {zenith.name}");

//while (zenith.Prefix != "Legendary") {
//    zenith.Reforge("Lazy");
  //  //Console.WriteLine($"{zenith.Prefix} {zenith.name}");
//}
//Console.WriteLine($"{zenith.Prefix} {zenith.name}");
/*
Inventory my_inv = new Inventory(5);
Item terrablade1 = new Item("Terra Blade", 122, "Legendary");
Item zenith1 = new Item("Zenith",3000,"Broken");

my_inv.Remove_item(zenith1);
my_inv.Add_item(terrablade1);


// shelf world yea very nice username
//Console.WriteLine(myItems);
public class Item
{
    public string name;
    public int BaseDamage;
    public string Prefix;
// null uyarini sikem senin rahat birak beni
    public Item(string name, int BaseDamage, string Prefix)
    {
        this.name = name;
        this.BaseDamage = BaseDamage;
        this.Prefix = Prefix;
    }
    public override string ToString()
    {
        return $"Name: {this.name}, BaseDamage: {this.BaseDamage}";
    }

List<string> prefixes = ["lazy","Legendary","weak","strong","keen","damaged"];
    public string Reforge(string Prefix)
    {
        Random rand = new Random();
        int randomIndex = rand.Next(0,prefixes.Count);
        this.Prefix = prefixes[randomIndex];  
        Console.WriteLine($"Reforged! New reforge is {this.Prefix} {this.name}.");
        return Prefix;
    }
}

public class Inventory
{
    List<string> myItems = [];
    public int inv_slot;

    public Inventory(int inv_slot)
    {
        this.inv_slot = inv_slot;

    }
    
    public void Add_item(Item item)
    {
         myItems.Add(item.name);
         Console.WriteLine($"{item.name} has added to the inventory!");
         
    }
    
    public void Remove_item(Item item)
   {
        myItems.Remove(item.name);
        Console.WriteLine($"{item.name} has removed from the inventory.");
   }

    

    public void ShowInventory()
    {
        Console.WriteLine(myItems);
    }    
    
    
    
}
*/


/*
List<string> Player_inv = [];



public class Player

{
    public string name;
    public int hp;
    public int InventorySlot;
    
    public Player (string name, int hp, int InventorySlot){
        this.name = name;
        this.hp = hp;
        this.InventorySlot = InventorySlot;
    }

    public void AddItems(Item targetItem)
    {
        Player_inv // I have to create an Item class

    }


}

public class Item
{
  public string Weapon_name;
  public int dmg;
  public string prefix;

  public Item(string Weapon_name, int dmg, string prefix)
  {
    this.Weapon_name = Weapon_name;
    this.dmg = dmg;
    this.prefix = prefix;
  }
List<string> prefixes = ["lazy","Legendary","weak","strong","keen","damaged"];
  public string Reforging(string prefix)
  {
    
  }
} */



    




    



//}
//Console.WriteLine($"{zenith.Prefix} {zenith.name}");
/*
Inventory my_inv = new Inventory(5);
Item terrablade1 = new Item("Terra Blade", 122, "Legendary");
Item zenith1 = new Item("Zenith",3000,"Broken");

my_inv.Remove_item(zenith1);
my_inv.Add_item(terrablade1);


// shelf world yea very nice username
//Console.WriteLine(myItems);
public class Item
{
    public string name;
    public int BaseDamage;
    public string Prefix;
// null uyarini sikem senin rahat birak beni
    public Item(string name, int BaseDamage, string Prefix)
    {
        this.name = name;
        this.BaseDamage = BaseDamage;
        this.Prefix = Prefix;
    }
    public override string ToString()
    {
        return $"Name: {this.name}, BaseDamage: {this.BaseDamage}";
    }

List<string> prefixes = ["lazy","Legendary","weak","strong","keen","damaged"];
    public string Reforge(string Prefix)
    {
        Random rand = new Random();
        int randomIndex = rand.Next(0,prefixes.Count);
        this.Prefix = prefixes[randomIndex];  
        Console.WriteLine($"Reforged! New reforge is {this.Prefix} {this.name}.");
        return Prefix;
    }
}

public class Inventory
{
    List<string> myItems = [];
    public int inv_slot;

    public Inventory(int inv_slot)
    {
        this.inv_slot = inv_slot;

    }
    
    public void Add_item(Item item)
    {
         myItems.Add(item.name);
         Console.WriteLine($"{item.name} has added to the inventory!");
         
    }
    
    public void Remove_item(Item item)
   {
        myItems.Remove(item.name);
        Console.WriteLine($"{item.name} has removed from the inventory.");
   }

    

    public void ShowInventory()
    {
        Console.WriteLine(myItems);
    }    
    
    
    
}




List<string> Player_inv = [];



public class Player

{
    public string name;
    public int hp;
    public int InventorySlot;
    
    public Player (string name, int hp, int InventorySlot){
        this.name = name;
        this.hp = hp;
        this.InventorySlot = InventorySlot;
    }

    public void AddItems(Item targetItem)
    {
        Player_inv // I have to create an Item class

    }


}

public class Item
{
  public string Weapon_name;
  public int dmg;
  public string prefix;

  public Item(string Weapon_name, int dmg, string prefix)
  {
    this.Weapon_name = Weapon_name;
    this.dmg = dmg;
    this.prefix = prefix;
  }
List<string> prefixes = ["lazy","Legendary","weak","strong","keen","damaged"];
  public string Reforging(string prefix)
  {
    
  }
}
   */

    


