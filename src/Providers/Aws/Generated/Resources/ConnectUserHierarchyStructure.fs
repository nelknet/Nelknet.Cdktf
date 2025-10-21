namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ConnectUserHierarchyStructureState<'HierarchyStructure, 'InstanceId> = { assignments: ResizeArray<aws.ConnectUserHierarchyStructure.ConnectUserHierarchyStructureConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_user_hierarchy_structure">aws_connect_user_hierarchy_structure</a>.
    /// </summary>
    type ConnectUserHierarchyStructureBuilder(logicalId: string) =
        member _.Yield(_: unit) : ConnectUserHierarchyStructureState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ConnectUserHierarchyStructureState<Missing, Missing>)

        member _.Zero(()) : ConnectUserHierarchyStructureState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ConnectUserHierarchyStructureState<Missing, Missing>)

        /// <summary>
        /// hierarchy_structure block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_user_hierarchy_structure#hierarchy_structure-1">ConnectUserHierarchyStructure#hierarchy_structure</a>
        /// </summary>
        [<CustomOperation "hierarchy_structure">]
        member _.HierarchyStructure(state: ConnectUserHierarchyStructureState<Missing, 'InstanceId>, value: aws.ConnectUserHierarchyStructure.ConnectUserHierarchyStructureHierarchyStructure) : ConnectUserHierarchyStructureState<Present, 'InstanceId> =
            state.assignments.Add(fun config -> config.HierarchyStructure <- value)
            ({ assignments = state.assignments } : ConnectUserHierarchyStructureState<Present, 'InstanceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_user_hierarchy_structure#instance_id-1">ConnectUserHierarchyStructure#instance_id</a>.
        /// </summary>
        [<CustomOperation "instance_id">]
        member _.InstanceId(state: ConnectUserHierarchyStructureState<'HierarchyStructure, Missing>, value: string) : ConnectUserHierarchyStructureState<'HierarchyStructure, Present> =
            state.assignments.Add(fun config -> config.InstanceId <- value)
            ({ assignments = state.assignments } : ConnectUserHierarchyStructureState<'HierarchyStructure, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_user_hierarchy_structure#id-1">ConnectUserHierarchyStructure#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ConnectUserHierarchyStructureState<'HierarchyStructure, 'InstanceId>, value: string) : ConnectUserHierarchyStructureState<'HierarchyStructure, 'InstanceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ConnectUserHierarchyStructureState<'HierarchyStructure, 'InstanceId>

        member _.Run(state: ConnectUserHierarchyStructureState<Present, Present>) : aws.ConnectUserHierarchyStructure.ConnectUserHierarchyStructure =
            let config = aws.ConnectUserHierarchyStructure.ConnectUserHierarchyStructureConfig()
            for setter in state.assignments do
                setter config
            aws.ConnectUserHierarchyStructure.ConnectUserHierarchyStructure(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.connectUserHierarchyStructure: missing required arguments. Must call: hierarchy_structure, instance_id.", 9999, IsError = true)>]
        member _.Run(_: ConnectUserHierarchyStructureState<_, _>) : aws.ConnectUserHierarchyStructure.ConnectUserHierarchyStructure =
            Unchecked.defaultof<aws.ConnectUserHierarchyStructure.ConnectUserHierarchyStructure>
