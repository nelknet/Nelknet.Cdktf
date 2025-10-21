namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsDxRouterConfigurationState<'RouterTypeIdentifier, 'VirtualInterfaceId> = { assignments: ResizeArray<aws.DataAwsDxRouterConfiguration.DataAwsDxRouterConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dx_router_configuration">aws_dx_router_configuration</a>.
    /// </summary>
    type DataAwsDxRouterConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsDxRouterConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsDxRouterConfigurationState<Missing, Missing>)

        member _.Zero(()) : DataAwsDxRouterConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsDxRouterConfigurationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dx_router_configuration#router_type_identifier-1">DataAwsDxRouterConfiguration#router_type_identifier</a>.
        /// </summary>
        [<CustomOperation "router_type_identifier">]
        member _.RouterTypeIdentifier(state: DataAwsDxRouterConfigurationState<Missing, 'VirtualInterfaceId>, value: string) : DataAwsDxRouterConfigurationState<Present, 'VirtualInterfaceId> =
            state.assignments.Add(fun config -> config.RouterTypeIdentifier <- value)
            ({ assignments = state.assignments } : DataAwsDxRouterConfigurationState<Present, 'VirtualInterfaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dx_router_configuration#virtual_interface_id-1">DataAwsDxRouterConfiguration#virtual_interface_id</a>.
        /// </summary>
        [<CustomOperation "virtual_interface_id">]
        member _.VirtualInterfaceId(state: DataAwsDxRouterConfigurationState<'RouterTypeIdentifier, Missing>, value: string) : DataAwsDxRouterConfigurationState<'RouterTypeIdentifier, Present> =
            state.assignments.Add(fun config -> config.VirtualInterfaceId <- value)
            ({ assignments = state.assignments } : DataAwsDxRouterConfigurationState<'RouterTypeIdentifier, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dx_router_configuration#id-1">DataAwsDxRouterConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsDxRouterConfigurationState<'RouterTypeIdentifier, 'VirtualInterfaceId>, value: string) : DataAwsDxRouterConfigurationState<'RouterTypeIdentifier, 'VirtualInterfaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsDxRouterConfigurationState<'RouterTypeIdentifier, 'VirtualInterfaceId>

        member _.Run(state: DataAwsDxRouterConfigurationState<Present, Present>) : aws.DataAwsDxRouterConfiguration.DataAwsDxRouterConfiguration =
            let config = aws.DataAwsDxRouterConfiguration.DataAwsDxRouterConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsDxRouterConfiguration.DataAwsDxRouterConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsDxRouterConfiguration: missing required arguments. Must call: router_type_identifier, virtual_interface_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsDxRouterConfigurationState<_, _>) : aws.DataAwsDxRouterConfiguration.DataAwsDxRouterConfiguration =
            Unchecked.defaultof<aws.DataAwsDxRouterConfiguration.DataAwsDxRouterConfiguration>
