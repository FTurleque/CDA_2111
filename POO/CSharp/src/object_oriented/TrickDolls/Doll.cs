using System;

namespace TrickDolls
{
    class Doll
    {
        private int _size;
        private bool _isOpen;
        private bool _isContainIn;
        private Doll _dollContain;
        private string _name;

        public Doll(string name, int size)
        {
            Name = name;
            Size = size;
            IsOpen = false;
            IsContainIn = false;
        }

        public bool IsContainIn
        {
            get { return _isContainIn; }
            set { _isContainIn = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Doll DollContain
        {
            get { return _dollContain; }
            set { _dollContain = value; }
        }

        public bool IsOpen
        {
            get { return _isOpen; }
            set { _isOpen = value; }
        }

        public int Size
        {
            get { return _size; }
            init { _size = value; }
        }

        public void Open()
        {
            if (!this.IsOpen) this.IsOpen = true;
            else Console.WriteLine("Déja ouverte.");
        }

        public void Close()
        {
            if (this.IsOpen) this.IsOpen = false;
            else Console.WriteLine("Déja fermé.");
        }

        public void PlaceDollIn(Doll bigDoll)
        {
            if (bigDoll.IsContainIn != false)
            {
                Console.WriteLine($"La poupée {bigDoll.Name} est déjà contenue dans une autre.");
            }
            else
            {
                if (!bigDoll.IsOpen) bigDoll.Open();
                if (this.Size < bigDoll.Size && bigDoll.DollContain == null)
                {
                    bigDoll.DollContain = this;
                    this.IsContainIn = true;
                    Console.WriteLine($"Vous mettez la poupée {this.Name} de taille {this.Size} à l'intérieur de {bigDoll.Name} de taille {bigDoll.Size}.");
                }
                else if (bigDoll.DollContain != null)
                {
                    Console.WriteLine($"La poupée {bigDoll.Name} à déja une poupée à l'interieur.");
                    bigDoll.Close();
                }
                else Console.WriteLine($"Vous ne pouvez pas mettre la poupée {this.Name} de taille {this.Size} à l'intérieur de {bigDoll.Name} de taille {bigDoll.Size}.");
            }
        }

        public void RemoveDollIn(Doll bigDoll)
        {
            
            if (bigDoll.IsContainIn != false) Console.WriteLine($"La poupée {bigDoll.Name} est contenu dans une autre poupée je ne peut pas l'ouvrir.");
            else
            {
                if (!bigDoll.IsOpen) bigDoll.Open();
                if (bigDoll.DollContain != null)
                {
                    bigDoll.DollContain = null;
                    this.IsContainIn = false;
                    Console.WriteLine($"Vous sortez la poupée {this.Name} de taille {this.Size} de {bigDoll.Name} de taille {bigDoll.Size}.");
                }
                else
                {
                    Console.WriteLine("La poupée est vide.");
                    bigDoll.Close();
                }
            }
        }

    }
}
