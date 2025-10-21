namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsConnectUserHierarchyStructureState<'InstanceId> = { assignments: ResizeArray<aws.DataAwsConnectUserHierarchyStructure.DataAwsConnectUserHierarchyStructureConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_user_hierarchy_structure">aws_connect_user_hierarchy_structure</a>.
    /// </summary>
    type DataAwsConnectUserHierarchyStructureBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsConnectUserHierarchyStructureState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsConnectUserHierarchyStructureState<Missing>)

        member _.Zero(()) : DataAwsConnectUserHierarchyStructureState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsConnectUserHierarchyStructureState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_user_hierarchy_structure#instance_id-1">DataAwsConnectUserHierarchyStructure#instance_id</a>.
        /// </summary>
        [<CustomOperation "instance_id">]
        member _.InstanceId(state: DataAwsConnectUserHierarchyStructureState<Missing>, value: string) : DataAwsConnectUserHierarchyStructureState<Present> =
            state.assignments.Add(fun config -> config.InstanceId <- value)
            ({ assignments = state.assignments } : DataAwsConnectUserHierarchyStructureState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_user_hierarchy_structure#id-1">DataAwsConnectUserHierarchyStructure#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsConnectUserHierarchyStructureState<'InstanceId>, value: string) : DataAwsConnectUserHierarchyStructureState<'InstanceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsConnectUserHierarchyStructureState<'InstanceId>

        member _.Run(state: DataAwsConnectUserHierarchyStructureState<Present>) : aws.DataAwsConnectUserHierarchyStructure.DataAwsConnectUserHierarchyStructure =
            let config = aws.DataAwsConnectUserHierarchyStructure.DataAwsConnectUserHierarchyStructureConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsConnectUserHierarchyStructure.DataAwsConnectUserHierarchyStructure(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsConnectUserHierarchyStructure: missing required arguments. Must call: instance_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsConnectUserHierarchyStructureState<_>) : aws.DataAwsConnectUserHierarchyStructure.DataAwsConnectUserHierarchyStructure =
            Unchecked.defaultof<aws.DataAwsConnectUserHierarchyStructure.DataAwsConnectUserHierarchyStructure>
