using System;
using System.Collections.Generic;
public struct Identity
{
    public Identity(String nom,String prénom, int age, String isman,String nation){
        Nom = nom;
        Prénom = prénom;
        Age = age;
        Sexe = isman;
        Nation = nation;
    }
    public int Age;
    public String Nom;
    public String Prénom;
    public String Sexe;
    public String Nation;
    
    
}
public struct Dialogue
{
    public Dialogue(){}
    
        public string[] salutation = {"Bon matin","Bien le bonjour","Buenas tardes","Bonsoir"};
        public string[] agréable = {"Il fait bon dehors","Tu es très jolie aujourd'hui!","Cette robe te vas bien","Je suis fier de toi"};
        public string[] desagreable = {"Il fait moche","Tu es moche","Cette robe te boudine","Je te deshérite"};
    

    
}
struct Object{
    public Object(){}
    public struct Chambre
       {
        public Chambre(){}
        public String[] lit = {"couette","mouchoir","oreiller","livre","pyjama","vernis","brosse a dent"};
        public String[] placard = {"pull","tee-shirt","pantalon","slip","chausette"};
        public String[] mur = {"poster de M pokora","photos avec des amis","objectifs","papier-paint","diplôme"};

       } 
    public struct Cuisine
       {
        public Cuisine(){}
        public String[] lavabo = {"éponge","produit vaisselle","vaisselle sale","torchon"};
        public String[] table = {"assiette","verres","fourchette","couteaux","serviettes","sel","poivre","pain","eau"};
        public String[] four = {"chien","pizza","grattin de gravier"};
        
       }
    public struct Salon 
       {
        public Salon(){}
        public String[] canape = {"telecommande","coussin","chat","porte-feuille","saleté"};
        public String[] table = {"devoir","vase","crayon","factures","colis","billet d'avion"};

       }
    
    }

class Position{
    public Position(double x,double y,double z){
        xpos = x;
        ypos = y;
        zpos = z;
    }
    public List<String> location = new List<string>() { "Coindejardin","Portique","PortePrincipal","Cuisine","Salon","Escalier","Chambre","Jardin","Entrée","PortiqueVoisin","Coinderue" };
    public double xpos , ypos , zpos;

}
 
        

class Program{
 
static void Main(string[] args){
    //fonction de spawn
    (double a,double b,double c) Throwlocation(int pos,double a,double b,double c){
        
    if(pos==1){a=0;b=0;c=0;}
    else if(pos==2){a=15;b=30;c=0;}
    else if(pos==3){a=37.5;b=10;c=0;}
    else if(pos==4){a=24;b=7;c=0;}
    else if(pos==5){a=25;b=15;c=0;}
    else if(pos==6){a=37.5;b=20;c=0;}
    else if(pos==7){a=27;b=22;c=0;}
    else if(pos==8){a=10;b=10;c=0;}
    else if(pos==9){a=35;b=5;c=0;}
    else if(pos==10){a=12;b=38;c=0;}
    else if(pos==11){a=50;b=38;c=0;}
    Position position = new Position(a,b,c);
    return(a,b,c);

  }


    //Formulaire du joueur
    String[] id = new string[3];
    String[] id_form = new string[3]{" le prénom ","le nom ","la nationalité "};
    for(int index = 0; index<3;index++){
        Console.WriteLine($"Entrez ,please ,"+id_form[index]+"du joueur:");
        
        id[index]=Console.ReadLine();
    }
    Thread.Sleep(1000);
    Console.Write("Merci , donc si je récapitule, les détails du joueur sont ");
    Thread.Sleep(2000);
     Console.Write("...\n");
     Thread.Sleep(2000);
     foreach(String element in id){
        Console.WriteLine(element);
    }
    Console.Write("Quelle âge à votre personnage?");
    int age = Console.Read();
    Console.Write("Est-ce une fille?(YES)(NO) :");
    String sexe = Console.ReadLine();
    Identity joueur = new Identity(id[0],id[1],age,sexe,id[2]);
    Console.Write("Votre joueur est enfin prêt!!");
    //Fin du Formulaire du joueur


    Thread.Sleep(1000);



    //Coin de spawn du joueur
    Console.WriteLine($"Choisissez le point d'apparition du joueur parmi la liste :");
    Position position = new Position(0,0,0);
    int i = 0;
    foreach(String item in position.location){
    i++;
    Console.BackgroundColor = ConsoleColor.Blue;
    Console.WriteLine(i+$"-"+item);
        }
    Console.BackgroundColor = ConsoleColor.Black;
    int pos = Console.Read();
     (double a,double b,double c) = Throwlocation(pos,0,0,0);
    Console.WriteLine($"La position en x est donc :"+a," de y :"+b," de z :"+c);

   

    }
    }


// Je souhaite Faire une liste des elements dans chaque struct 
//Je veux creer une classe position qui est associé à un point dans un ensemble de point représentant un lieu dans la propriété

//Je voudrais savoir si une fonction peut retourner un type liste

//je veux créer des conditions entre les strutures en fonctions des positions
//A chaque point je veux associer une image du sujet 
//Je veux utiliser la fenetre graphique de unity
//Je veux creer un cycle temporel pour faire interagir les points ensemble afin de creer des conversations entre les membres de la famille
//Je veux creer un perso qui peut lui aussi ce deplacer et interagir avec les autres

