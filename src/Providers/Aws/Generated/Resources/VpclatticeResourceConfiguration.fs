namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpclatticeResourceConfigurationState<'Name> = { assignments: ResizeArray<aws.VpclatticeResourceConfiguration.VpclatticeResourceConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_resource_configuration">aws_vpclattice_resource_configuration</a>.
    /// </summary>
    type VpclatticeResourceConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpclatticeResourceConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : VpclatticeResourceConfigurationState<Missing>)

        member _.Zero(()) : VpclatticeResourceConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : VpclatticeResourceConfigurationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_resource_configuration#name-1">VpclatticeResourceConfiguration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VpclatticeResourceConfigurationState<Missing>, value: string) : VpclatticeResourceConfigurationState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VpclatticeResourceConfigurationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_resource_configuration#allow_association_to_shareable_service_network-1">VpclatticeResourceConfiguration#allow_association_to_shareable_service_network</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "allow_association_to_shareable_service_network">]
        member _.AllowAssociationToShareableServiceNetwork(state: VpclatticeResourceConfigurationState<'Name>, value: bool) : VpclatticeResourceConfigurationState<'Name> =
            state.assignments.Add(fun config -> config.AllowAssociationToShareableServiceNetwork <- value)
            state : VpclatticeResourceConfigurationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_resource_configuration#allow_association_to_shareable_service_network-1">VpclatticeResourceConfiguration#allow_association_to_shareable_service_network</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "allow_association_to_shareable_service_network">]
        member _.AllowAssociationToShareableServiceNetwork(state: VpclatticeResourceConfigurationState<'Name>, value: HashiCorp.Cdktf.IResolvable) : VpclatticeResourceConfigurationState<'Name> =
            state.assignments.Add(fun config -> config.AllowAssociationToShareableServiceNetwork <- value)
            state : VpclatticeResourceConfigurationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_resource_configuration#port_ranges-1">VpclatticeResourceConfiguration#port_ranges</a>.
        /// </summary>
        [<CustomOperation "port_ranges">]
        member _.PortRanges(state: VpclatticeResourceConfigurationState<'Name>, value: seq<string>) : VpclatticeResourceConfigurationState<'Name> =
            state.assignments.Add(fun config -> config.PortRanges <- (value |> Seq.toArray))
            state : VpclatticeResourceConfigurationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_resource_configuration#protocol-1">VpclatticeResourceConfiguration#protocol</a>.
        /// </summary>
        [<CustomOperation "protocol">]
        member _.Protocol(state: VpclatticeResourceConfigurationState<'Name>, value: string) : VpclatticeResourceConfigurationState<'Name> =
            state.assignments.Add(fun config -> config.Protocol <- value)
            state : VpclatticeResourceConfigurationState<'Name>

        /// <summary>
        /// resource_configuration_definition block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_resource_configuration#resource_configuration_definition-1">VpclatticeResourceConfiguration#resource_configuration_definition</a> Accepts: aws.IResolvable | aws.VpclatticeResourceConfiguration.VpclatticeResourceConfigurationResourceConfigurationDefinition[]
        /// </summary>
        [<CustomOperation "resource_configuration_definition">]
        member _.ResourceConfigurationDefinition(state: VpclatticeResourceConfigurationState<'Name>, value: HashiCorp.Cdktf.IResolvable) : VpclatticeResourceConfigurationState<'Name> =
            state.assignments.Add(fun config -> config.ResourceConfigurationDefinition <- value)
            state : VpclatticeResourceConfigurationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_resource_configuration#resource_configuration_group_id-1">VpclatticeResourceConfiguration#resource_configuration_group_id</a>.
        /// </summary>
        [<CustomOperation "resource_configuration_group_id">]
        member _.ResourceConfigurationGroupId(state: VpclatticeResourceConfigurationState<'Name>, value: string) : VpclatticeResourceConfigurationState<'Name> =
            state.assignments.Add(fun config -> config.ResourceConfigurationGroupId <- value)
            state : VpclatticeResourceConfigurationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_resource_configuration#resource_gateway_identifier-1">VpclatticeResourceConfiguration#resource_gateway_identifier</a>.
        /// </summary>
        [<CustomOperation "resource_gateway_identifier">]
        member _.ResourceGatewayIdentifier(state: VpclatticeResourceConfigurationState<'Name>, value: string) : VpclatticeResourceConfigurationState<'Name> =
            state.assignments.Add(fun config -> config.ResourceGatewayIdentifier <- value)
            state : VpclatticeResourceConfigurationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_resource_configuration#tags-1">VpclatticeResourceConfiguration#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VpclatticeResourceConfigurationState<'Name>, value: seq<string * string>) : VpclatticeResourceConfigurationState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VpclatticeResourceConfigurationState<'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_resource_configuration#timeouts-1">VpclatticeResourceConfiguration#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VpclatticeResourceConfigurationState<'Name>, value: aws.VpclatticeResourceConfiguration.VpclatticeResourceConfigurationTimeouts) : VpclatticeResourceConfigurationState<'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VpclatticeResourceConfigurationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_resource_configuration#type-1">VpclatticeResourceConfiguration#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: VpclatticeResourceConfigurationState<'Name>, value: string) : VpclatticeResourceConfigurationState<'Name> =
            state.assignments.Add(fun config -> config.Type <- value)
            state : VpclatticeResourceConfigurationState<'Name>

        member _.Run(state: VpclatticeResourceConfigurationState<Present>) : aws.VpclatticeResourceConfiguration.VpclatticeResourceConfiguration =
            let config = aws.VpclatticeResourceConfiguration.VpclatticeResourceConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.VpclatticeResourceConfiguration.VpclatticeResourceConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpclatticeResourceConfiguration: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: VpclatticeResourceConfigurationState<_>) : aws.VpclatticeResourceConfiguration.VpclatticeResourceConfiguration =
            Unchecked.defaultof<aws.VpclatticeResourceConfiguration.VpclatticeResourceConfiguration>
