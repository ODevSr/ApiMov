namespace ApiMov.Models
{
    public class Mov
    {
        public int ID { get; set; }
        public required string TP_MOV { get; set; }
        public required DateTime DT_MOV { get; set; }
        public required float VL_MOV { get; set; }
        public required string DS_MOV { get; set; }
    }
}
