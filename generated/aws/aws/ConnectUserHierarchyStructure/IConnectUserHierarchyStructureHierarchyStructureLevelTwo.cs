using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConnectUserHierarchyStructure
{
    [JsiiInterface(nativeType: typeof(IConnectUserHierarchyStructureHierarchyStructureLevelTwo), fullyQualifiedName: "aws.connectUserHierarchyStructure.ConnectUserHierarchyStructureHierarchyStructureLevelTwo")]
    public interface IConnectUserHierarchyStructureHierarchyStructureLevelTwo
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_user_hierarchy_structure#name ConnectUserHierarchyStructure#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IConnectUserHierarchyStructureHierarchyStructureLevelTwo), fullyQualifiedName: "aws.connectUserHierarchyStructure.ConnectUserHierarchyStructureHierarchyStructureLevelTwo")]
        internal sealed class _Proxy : DeputyBase, aws.ConnectUserHierarchyStructure.IConnectUserHierarchyStructureHierarchyStructureLevelTwo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_user_hierarchy_structure#name ConnectUserHierarchyStructure#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
