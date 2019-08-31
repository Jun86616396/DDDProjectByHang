namespace DDD.Application.DTO.DayFinished
{
    public class DayFinishedDto
    {
        public int Id { get; set; }

        public string CreateTime { get; set; }
        public int CollectionCount { get; set; }
        public int AssembleCount { get; set; }
        public int FistTestCount { get; set; }
        public int LastTestCount { get; set; }
        public int StorageCount { get; set; }

        public int SynchronizationFlag { get; set; }
    }
}