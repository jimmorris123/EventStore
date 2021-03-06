namespace EventStore.Projections.Core.Messages.Persisted.Commands
{
    public class CreateAndPrepareSlaveCommand
    {
        public string Id { get; set; }
        public string MasterCoreProjectionId { get; set; }
        public string MasterWorkerId { get; set; }
        public PersistedProjectionConfig Config { get; set; }
        public PersistedProjectionVersion Version { get; set; }
        public string HandlerType { get; set; }
        public string Query { get; set; }
        public string Name { get; set; }
    }
}