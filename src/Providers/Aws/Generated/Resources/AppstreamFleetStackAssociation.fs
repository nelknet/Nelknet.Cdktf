namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppstreamFleetStackAssociationState<'FleetName, 'StackName> = { assignments: ResizeArray<aws.AppstreamFleetStackAssociation.AppstreamFleetStackAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_fleet_stack_association">aws_appstream_fleet_stack_association</a>.
    /// </summary>
    type AppstreamFleetStackAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppstreamFleetStackAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AppstreamFleetStackAssociationState<Missing, Missing>)

        member _.Zero(()) : AppstreamFleetStackAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AppstreamFleetStackAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_fleet_stack_association#fleet_name-1">AppstreamFleetStackAssociation#fleet_name</a>.
        /// </summary>
        [<CustomOperation "fleet_name">]
        member _.FleetName(state: AppstreamFleetStackAssociationState<Missing, 'StackName>, value: string) : AppstreamFleetStackAssociationState<Present, 'StackName> =
            state.assignments.Add(fun config -> config.FleetName <- value)
            ({ assignments = state.assignments } : AppstreamFleetStackAssociationState<Present, 'StackName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_fleet_stack_association#stack_name-1">AppstreamFleetStackAssociation#stack_name</a>.
        /// </summary>
        [<CustomOperation "stack_name">]
        member _.StackName(state: AppstreamFleetStackAssociationState<'FleetName, Missing>, value: string) : AppstreamFleetStackAssociationState<'FleetName, Present> =
            state.assignments.Add(fun config -> config.StackName <- value)
            ({ assignments = state.assignments } : AppstreamFleetStackAssociationState<'FleetName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_fleet_stack_association#id-1">AppstreamFleetStackAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppstreamFleetStackAssociationState<'FleetName, 'StackName>, value: string) : AppstreamFleetStackAssociationState<'FleetName, 'StackName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppstreamFleetStackAssociationState<'FleetName, 'StackName>

        member _.Run(state: AppstreamFleetStackAssociationState<Present, Present>) : aws.AppstreamFleetStackAssociation.AppstreamFleetStackAssociation =
            let config = aws.AppstreamFleetStackAssociation.AppstreamFleetStackAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.AppstreamFleetStackAssociation.AppstreamFleetStackAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.appstreamFleetStackAssociation: missing required arguments. Must call: fleet_name, stack_name.", 9999, IsError = true)>]
        member _.Run(_: AppstreamFleetStackAssociationState<_, _>) : aws.AppstreamFleetStackAssociation.AppstreamFleetStackAssociation =
            Unchecked.defaultof<aws.AppstreamFleetStackAssociation.AppstreamFleetStackAssociation>
