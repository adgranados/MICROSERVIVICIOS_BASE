using System;

namespace DATABASE_MODELS.Models
{
    public partial class DataDictionary
    {
        public int Id { get; set; }
        public DateTime? ChangeDate { get; set; }
        public string Server { get; set; }
        public string Database { get; set; }
        public string ObjectType { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public int? ObjectId { get; set; }
        public bool? DiffCode { get; set; }
        public string DiffType { get; set; }
        public string DiffAnsi { get; set; }
        public string DiffAssembly { get; set; }
        public string DiffAssemblyClass { get; set; }
        public string DiffAssemblyMethod { get; set; }
        public string DiffBaseType { get; set; }
        public string DiffBody { get; set; }
        public string DiffBoundDefault { get; set; }
        public string DiffBoundDefaults { get; set; }
        public string DiffBoundRule { get; set; }
        public string DiffBoundRules { get; set; }
        public string DiffChangeTracking { get; set; }
        public string DiffCheckConstraints { get; set; }
        public string DiffClrname { get; set; }
        public string DiffColumnOrder { get; set; }
        public string DiffColumns { get; set; }
        public string DiffDataspace { get; set; }
        public string DiffDefaultConstraints { get; set; }
        public string DiffDefaultSchema { get; set; }
        public string DiffDurability { get; set; }
        public string DiffExtendedProperties { get; set; }
        public string DiffFiles { get; set; }
        public string DiffForeignKeys { get; set; }
        public string DiffFulltextIndex { get; set; }
        public string DiffIdentities { get; set; }
        public string DiffIndexes { get; set; }
        public string DiffLockEscalation { get; set; }
        public string DiffManifestFile { get; set; }
        public string DiffMemoryOptimized { get; set; }
        public string DiffNullable { get; set; }
        public string DiffOwner { get; set; }
        public string DiffParameters { get; set; }
        public string DiffPermissions { get; set; }
        public string DiffPermissionSet { get; set; }
        public string DiffPrimaryKey { get; set; }
        public string DiffReturnType { get; set; }
        public string DiffScale { get; set; }
        public string DiffSize { get; set; }
        public string DiffStatistics { get; set; }
        public string DiffUnique { get; set; }
        public string DiffUserLogin { get; set; }
        public string DiffXmlcolumnSet { get; set; }
        public string DiffXmlindexes { get; set; }
        public string Ddl { get; set; }
    }
}
