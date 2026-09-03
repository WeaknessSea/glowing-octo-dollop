#Dungeon
import random
class Character:
    def __init__(self, hp, name, att_power, character_type):
        self.hp = hp
        self.name = name
        self.att_power = att_power
        self.character_type = character_type

    @classmethod
    def create_goblin(cls):
        return cls(50, "Goblin", 12, "Enemy")

    @classmethod
    def create_EoW(cls):
        return cls(4000, "Eater of Worlds", 120, "Boss")

    def attackTargetAttacker(self, target, attacker):
        damage = attacker.att_power
        target.hp = target.hp - damage

    def attackTargetAttackerDefenseMode(self, target, attacker):
        damage = attacker.att_power / 2
        target.hp = target.hp - damage

#character1.attack(goblin1)

class Item:
    def __init__(self, name, durability, max_durability):
        self.name = name
        self.durability = durability
        self.max_durability = max_durability

    def __str__(self):
        return f"Name: {self.name}, durability: {self.durability}, max_durability: {self.max_durability}"
    
    @classmethod
    def create_iron_sword(cls):
        return cls("Iron Sword", 250, 250)

    @classmethod
    def create_iron_armor(cls):
        return cls(f"Iron Armor", 134, 134)

    @classmethod
    def drop_Terrablade(cls):
        return cls("TerraBlade", 1000, 10000 )

    @classmethod
    def dropZenith(cls):
        return cls("Zenith", 99999,99999)

class Inventory:
    def __init__(self, capacity):
        self.capacity = capacity
        self.items = []

    def add_item(self, target_item):
        if len(self.items) < self.capacity:
            self.items.append(target_item)
            print(f"{target_item} has been added to the inventory!")
        else:
            print(f"{target_item} has not been added to the inventory")

    def __str__(self):
        return f"{self.items}"
 
iron_armor1 = Item.create_iron_sword()
iron_sword1 = Item.create_iron_sword()
character1 = Character(400,"HelloWorld", 26, "Hero")
character1_inv = Inventory(6)


print(f"WELCOME TO THE DUNGEON BOIIIIIIIIII")
print(f"Hello bro! This is your profile: {character1}")
print("You also have an inventory with 6 capacity.")

#also add repair system, gold system

while character1.hp > 0:

    enemyChance = random.randint(1, 100)
    if enemyChance > 10:
        enemy = Character.create_goblin()
    else:
        enemy = Character.create_EoW()

    print(f"You encountered a {enemy.name}. What you gonna do?")
    while enemy.hp > 0 and character1.hp > 0:
            player_choice = input("[Attack] [Defense] [Escape]")

            #ATTACK
            if player_choice == "Attack":
                character1.attackTargetAttacker(enemy,character1)
                print(f"You attacked to {enemy.name}! Remaining HP is {enemy.hp}")

                if enemy.hp <= 0:
                    enemy.hp = 0
                    print(f"You defeated goblin!")

                    #LOOT SYSTEM
                    loot_chance = random.randint(1,50)
                    if loot_chance > 40:
                        zenith1 = Item.dropZenith()
                        character1_inv.add_item(zenith1)
                        print("The goblin dropped Zenith! Lucky. Added to inv.")
                        
                    elif loot_chance > 20:
                        terraBlade1 = Item.drop_Terrablade()
                        character1_inv.add_item(terraBlade1)
                        print(f"The goblin dropped Terra Blade! Added to inv.")
                    break
                enemy.attackTargetAttacker(character1,enemy)
                print(f"{enemy.name} attacked you! Your HP is: {character1.hp}")
            
            elif player_choice == "Defense":
                enemy.attackTargetAttackerDefenseMode(character1,enemy)
                print(f"{enemy.name} attacked you! Your hp is {character1.hp}")
            elif player_choice == "Escape":
                escapeChance = random.randint(1,3)
                if escapeChance == 1:
                    print(f"You escaped succesfully!")
                    
            else:
                enemy.attackTargetAttacker(character1,enemy)
                print(f"You couldn't escape! {enemy.name} attacked you! Your hp is: {character1.hp}")
    if character1.hp <= 0:
        print(f"You died! Game's over...")
        break

    print(f"\n" + "="*30)

    continue_choice = input("Continue or quit [c] or [q] ?").lower()
    if continue_choice == "c":
        after_escape_choice = input(f"Show inventory before next match? [y] [n]").lower()
        if after_escape_choice == "y":
            print(character1_inv)
        print(f"ok boi let's continue!")
        continue
    elif continue_choice == "q":
        print("quitting the dungeon...")
        break

