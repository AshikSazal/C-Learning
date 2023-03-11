using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    public class Computer
    {
        public string Monitor { get; set; }
        public string Mouse { get; set; }
        public string Keyboard { get; set; }
        public string Tower { get; set; }
        public string Printer { get; set; }
    }
    public interface IComputerBuilder
    {
        void SetMonitor();
        void SetMouse();
        void SetKeyboard();
        void SetTower();
        void SetPrinter();

        Computer GetComputer();
    }
    public class ComputerABuilder : IComputerBuilder
    {
        Computer computer = new Computer();
        
        public void SetMonitor()
        {
            computer.Monitor = "Single";
        }

        public void SetMouse()
        {
            computer.Mouse = "Regular";
        }

        public void SetKeyboard()
        {
            computer.Keyboard = "Standard";
        }

        public void SetTower()
        {
            computer.Tower = "16GB RAM";
        }

        public void SetPrinter()
        {
            computer.Printer = "HP Laserjet 5000";
        }

        public Computer GetComputer()
        {
            return computer;
        }
    }

    public class ComputerBBuilder : IComputerBuilder
    {
        Computer computer = new Computer();

        public void SetMonitor()
        {
            computer.Mouse = "Dual";
        }

        public void SetKeyboard()
        {
            computer.Keyboard = "Standard";
        }

        public void SetMouse()
        {
            computer.Mouse = "Gaming";
        }

        public void SetPrinter()
        {
            computer.Printer = "HP Laserjet 7000";
        }

        public void SetTower()
        {
            computer.Tower = "64GB RAM";
        }

        public Computer GetComputer()
        {
            return computer;
        }
    }

    public class ComputerCreator
    {
        private IComputerBuilder computerBuilder;

        public ComputerCreator(IComputerBuilder computerBuilder)
        {
            this.computerBuilder = computerBuilder;
        }
        public void CreateComputer()
        {
            computerBuilder.SetMonitor();
            computerBuilder.SetMouse();
            computerBuilder.SetKeyboard();
            computerBuilder.SetPrinter();
            computerBuilder.SetTower();
        }
        public Computer GetComputer()
        {
            return computerBuilder.GetComputer();
        }
    }

    class Program
    {
        static void Main(string[] args) { 
            
            ComputerCreator computerACreator = new ComputerCreator(new ComputerABuilder());
            computerACreator.CreateComputer();
            Debug.WriteLine(computerACreator.GetComputer().Monitor);
            Debug.WriteLine(computerACreator.GetComputer().Mouse);
            Debug.WriteLine(computerACreator.GetComputer().Keyboard);
            Debug.WriteLine(computerACreator.GetComputer().Printer);
            Debug.WriteLine(computerACreator.GetComputer().Tower);

            ComputerCreator computerBCreator = new ComputerCreator(new ComputerBBuilder());
            computerBCreator.CreateComputer();
            Debug.WriteLine(computerBCreator.GetComputer().Monitor);
            Debug.WriteLine(computerBCreator.GetComputer().Mouse);
            Debug.WriteLine(computerBCreator.GetComputer().Keyboard);
            Debug.WriteLine(computerBCreator.GetComputer().Printer);
            Debug.WriteLine(computerBCreator.GetComputer().Tower);
        }
    }
}
