namespace MVCWebUI.Models
{
    public class StructureItem
    {
        public int structureID { get; set; }
        public string structureName { get; set; }
        public string structureAddress { get; set; }
        public string? managerName { get; set; }
        public string? managerPhone { get; set; }
        public DateTime? lastMaintenanceDate { get; set; }
        public int? debtInfo { get; set; }
        public string? elevatorInfo { get; set; }
    }
}
