using System.Net.Quic;

Player player1 = new Player("Ryuk","Mage",500);
player1.Print_player();
List<string> player_inv = [];

// CREATE WEAPONS

Items Terra_blade1 = new Items("Terra Blade", "Agile", 109);
Items Mini_shark1 = new Items("Mini Shark", "Damaged", 16);
Items Volcano1 = new Items("Volcano", "Godly", 45);


player1.equipWeapon(Terra_blade1);
// CREATE ENEMIES 
Enemy Moon_lord1 = new Enemy("Moon Lord", 100, 230000, true);

// MAIN LOOP

Console.WriteLine("Welcome to the enemy simulation bro");
Console.WriteLine("You will encounter a few enemies and choose what to do.");

Random rand = new Random();
while (player1.player_hp > 0)
{  
  Enemy current_enemy;
  int enemy_chance = rand.Next(1, 101);
  if (enemy_chance > 30)
  {
    current_enemy = new Enemy("Goblin", 20, 50, false );
  }
  else
  {
    current_enemy = new Enemy("Eater Of Worlds", 40, 4000, true);
  }
  while (player1.player_hp > 0 && current_enemy.enemy_hp > 0)
  {
    Console.WriteLine($"You encountered to {current_enemy.enemy_name}");
    Console.WriteLine("What you gonna do? [a] [d] [e]");
    string user_choice = Console.ReadLine().ToUpper();
    if (user_choice == "A")
    {
      player1.Attack(current_enemy);
    }
    else if (user_choice == "D")
    {
      player1.Defense(current_enemy);
    }
    else if (user_choice == "E")
    {
      bool escaped = player1.Escape();
      if (escaped == true)
      {
        break;
      }
    }
    else
    {
      Console.WriteLine("You entered a wrong letter.");
    }
    if (current_enemy.enemy_hp > 0 && user_choice != "E")
    {
      player1.player_hp -= current_enemy.enemy_dmg;
      Console.WriteLine($"{current_enemy.enemy_name} dealt you {current_enemy.enemy_dmg}! Your hp {player1.player_hp}.");
    }
  if (player1.player_hp <= 0)
    {
      Console.WriteLine("You died. RIP");
      break;
    }
  else if (current_enemy.enemy_hp <= 0)
    {
      Console.WriteLine($"You succesfully defeated {current_enemy.enemy_name}!");
    }
  } 
}

public class Player
{
  public string player_name;
  public string player_class;
  public int player_hp;
  public Items current_weapon;
  public Inventory Backpack;

  public Player(string player_name, string player_class, int player_hp)
  {
    this.player_name = player_name;
    this.player_class = player_class;
    this.player_hp = player_hp;  
    this.Backpack = new Inventory(10);


  }
  public void Print_player()
  {
    Console.WriteLine($"Name: {this.player_name}, Class: {this.player_class}, HP: {this.player_hp} ");

  }
  public void Print_inv()
  {
    Console.WriteLine($"{player_name}'s inventory: {this.Backpack}");
  }


  public void Attack(Enemy enemy)
  {

    int damage_dealt = 20;
    if (current_weapon != null)
    {
      damage_dealt = current_weapon.weapon_dmg;
    }
    enemy.enemy_hp -= damage_dealt;
    Console.WriteLine($"You did {damage_dealt} dmg, enemy's hp: {enemy.enemy_hp}");
  }
  public void Defense(Enemy enemy)
  {
    this.player_hp -= enemy.enemy_dmg / 2;
    Console.WriteLine($"You defended! You took {enemy.enemy_dmg/2} damage!");
  }

  public bool Escape()
  {
    // int random_index = rand.Next(0, prefixes.Count);
    Random rand = new Random();
    int escape_chance = rand.Next(0,3);
    if (escape_chance == 1)
    {
      Console.WriteLine($"You escaped successfully.");
      return true;
    }
    else
    {
      Console.WriteLine("You couldn't escape...");
      return false;
    }
  }

  public void equipWeapon(Items target_weapon)
  {
    this.current_weapon = target_weapon;
    Console.WriteLine($"{target_weapon.weapon_name} equipped! ");
  }


}


public class Inventory
{
  public int capacity;
  public Inventory(int capacity)
  {
    this.capacity = capacity;
  }
  public void printInv(List<string> player_inv)
  {
    Console.WriteLine($"Inventory: {player_inv}");
  }

  public void AddItem(Items item)
  {
    /*if (item.Count < capacity)
    {
      Items.Add(item);
    }*/
  }

}

public class Items
{
  public string weapon_name;
  public string prefix;
  public int weapon_dmg;
  public List<string> prefixes = new List<string>()
  {
   "lazy","Legendary","weak","strong","keen","damaged"
  };


  public Items(string weapon_name, string prefix, int weapon_dmg)
  {
    this.weapon_name = weapon_name;
    this.prefix = prefix;
    this.weapon_dmg = weapon_dmg;
  }
  public void Reforge()
  {
    Random rand = new Random();
    int random_index = rand.Next(0, prefixes.Count);
    this.prefix = prefixes[random_index];
    Console.WriteLine($"Reforged! New reforge is {this.prefix} {this.weapon_name}"); 
    
  }


} 

public class Enemy
{
  public string enemy_name;
  public int enemy_dmg;
  public int enemy_hp;
  public bool is_enemy_boss;

  public Enemy(string enemy_name, int enemy_dmg, int enemy_hp, bool is_enemy_boss)
  {
    this.enemy_name = enemy_name;
    this.enemy_dmg = enemy_dmg;
    this.enemy_hp = enemy_hp;
    this.is_enemy_boss = is_enemy_boss;
  }


}