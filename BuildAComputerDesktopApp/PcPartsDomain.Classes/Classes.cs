namespace PcPartsDomain.Classes
{
    public class PC
    {
        public CPU CPU {get;set;}
        public GPU GPU { get; set; }
        public Memory Memory { get; set; }
        public MotherBoard Mobo { get; set; }
        public PowerSupply PowerSupply { get; set;  }
    }

    public class CPU
    {
        public string name { get; set; }
        public string brand { get; set; }
        public string gen { get; set; }
        public string socket { get; set; }
        public int core { get; set; }
        public int thread { get; set; }
        public decimal speed { get; set; }
        public decimal price { get; set; }
        public string series { get; set; }
    }
    public class GPU
    {
        public string gpu { get; set; }
        public int GPUmemory { get; set; }
        public string memoryType { get; set; }
        public int memoryInterface { get; set; }
    }
    public class Memory
    {
        public string name { get; set; }
        public string brand { get; set; }
        public int capacity { get; set; }
        public int speed { get; set; }
        public string timing { get; set; }
        public string price { get; set; }
    }
    public class MotherBoard
    {
        public string name { get; set; }
        public string brand { get; set; }
        public string socket { get; set; }
        public string chipset { get; set; }
        public decimal price { get; set; }
        public int usbPorts { get; set; }
        public int PCIthree { get; set; }
    }
    public class PowerSupply
    {
        public string name { get; set; }
        public string brand { get; set; }
        public int maxPower { get; set; }
        public int fans{ get; set; }
        public string energyEfficiency { get; set; }
        public decimal weight { get; set; }
        public decimal price { get; set; }
    }


}
