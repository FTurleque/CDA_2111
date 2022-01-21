using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianDolls
{
    class Doll
    {
        private int _size;
        private bool _isOpen;
        private bool _isContainIn;
        private Doll _externDoll;
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

        public Doll ExternDoll
        {
            get { return _externDoll; }
            set { _externDoll = value; }
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
            if (!this.IsOpen && this.ExternDoll == null) 
                this.IsOpen = true;
            else if (this.ExternDoll != null && this.ExternDoll.IsOpen == false) 
                Console.WriteLine("The doll is contained in another one that is closed");
            else Console.WriteLine("Already open.");
        }

        public void Close()
        {
            if (this.IsOpen && !(this.ExternDoll != null && this.ExternDoll.IsOpen == false)) 
                this.IsOpen = false;
            else if (this.ExternDoll != null && this.ExternDoll.IsOpen == false) 
                Console.WriteLine("The doll is contained in another one that is closed");
            else Console.WriteLine("Already closed.");
        }

        public void PlaceDollIn(Doll bigDoll)
        {
            if (this.IsContainIn != false) 
                Console.WriteLine($"The {this.Name} doll is contained in another doll I can't open it.");
            else if (bigDoll.IsContainIn != false) 
                Console.WriteLine($"The {bigDoll.Name} doll is contained in another doll I can't open it.");
            else
            {
                if (!bigDoll.IsOpen)
                {
                    Console.WriteLine("The doll is closed open it.");
                }
                else
                {
                    if (this.Size < bigDoll.Size && bigDoll.DollContain == null)
                    {
                        bigDoll.DollContain = this;
                        this.IsContainIn = true;
                        ExternDoll = bigDoll;
                        Console.WriteLine(
                            $"You put the {this.Name} doll of size {this.Size} inside {bigDoll.Name} doll of size {bigDoll.Size}.");
                    }
                    else if (bigDoll.DollContain != null)
                    {
                        Console.WriteLine($"The {bigDoll.Name} doll has already a doll inside.");
                        bigDoll.Close();
                    }
                    else Console.WriteLine(
                        $"You cannot put the {this.Name} doll of size {this.Size} inside {bigDoll.Name} doll of size {bigDoll.Size}.");
                }
                
            }
        }

        public void RemoveDollIn(Doll bigDoll)
        {

            if (bigDoll.IsContainIn != false) 
                Console.WriteLine($"The {bigDoll.Name} doll is contained in another doll I can't open it.");
            else if (bigDoll.DollContain.Name != this.Name) 
                Console.WriteLine($"{this.Name} doll is not in {bigDoll.Name}");
            else
            {
                if (!bigDoll.IsOpen) bigDoll.Open();
                if (bigDoll.DollContain != null)
                {
                    bigDoll.DollContain = null;
                    this.IsContainIn = false;
                    ExternDoll = null;
                    Console.WriteLine($"You take out {this.Name} of {bigDoll.Name} doll.");
                }
                else
                {
                    Console.WriteLine("The doll is empty.");
                    bigDoll.Close();
                }
            }
        }
    }
}
