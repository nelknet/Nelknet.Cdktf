namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GlobalacceleratorCustomRoutingAcceleratorState<'Name> = { assignments: ResizeArray<aws.GlobalacceleratorCustomRoutingAccelerator.GlobalacceleratorCustomRoutingAcceleratorConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_custom_routing_accelerator">aws_globalaccelerator_custom_routing_accelerator</a>.
    /// </summary>
    type GlobalacceleratorCustomRoutingAcceleratorBuilder(logicalId: string) =
        member _.Yield(_: unit) : GlobalacceleratorCustomRoutingAcceleratorState<Missing> =
            ({ assignments = ResizeArray() } : GlobalacceleratorCustomRoutingAcceleratorState<Missing>)

        member _.Zero(()) : GlobalacceleratorCustomRoutingAcceleratorState<Missing> =
            ({ assignments = ResizeArray() } : GlobalacceleratorCustomRoutingAcceleratorState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_custom_routing_accelerator#name-1">GlobalacceleratorCustomRoutingAccelerator#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: GlobalacceleratorCustomRoutingAcceleratorState<Missing>, value: string) : GlobalacceleratorCustomRoutingAcceleratorState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : GlobalacceleratorCustomRoutingAcceleratorState<Present>)

        /// <summary>
        /// attributes block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_custom_routing_accelerator#attributes-1">GlobalacceleratorCustomRoutingAccelerator#attributes</a>
        /// </summary>
        [<CustomOperation "attributes">]
        member _.Attributes(state: GlobalacceleratorCustomRoutingAcceleratorState<'Name>, value: aws.GlobalacceleratorCustomRoutingAccelerator.GlobalacceleratorCustomRoutingAcceleratorAttributes) : GlobalacceleratorCustomRoutingAcceleratorState<'Name> =
            state.assignments.Add(fun config -> config.Attributes <- value)
            state : GlobalacceleratorCustomRoutingAcceleratorState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_custom_routing_accelerator#enabled-1">GlobalacceleratorCustomRoutingAccelerator#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: GlobalacceleratorCustomRoutingAcceleratorState<'Name>, value: bool) : GlobalacceleratorCustomRoutingAcceleratorState<'Name> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : GlobalacceleratorCustomRoutingAcceleratorState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_custom_routing_accelerator#enabled-1">GlobalacceleratorCustomRoutingAccelerator#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: GlobalacceleratorCustomRoutingAcceleratorState<'Name>, value: HashiCorp.Cdktf.IResolvable) : GlobalacceleratorCustomRoutingAcceleratorState<'Name> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : GlobalacceleratorCustomRoutingAcceleratorState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_custom_routing_accelerator#id-1">GlobalacceleratorCustomRoutingAccelerator#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GlobalacceleratorCustomRoutingAcceleratorState<'Name>, value: string) : GlobalacceleratorCustomRoutingAcceleratorState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GlobalacceleratorCustomRoutingAcceleratorState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_custom_routing_accelerator#ip_addresses-1">GlobalacceleratorCustomRoutingAccelerator#ip_addresses</a>.
        /// </summary>
        [<CustomOperation "ip_addresses">]
        member _.IpAddresses(state: GlobalacceleratorCustomRoutingAcceleratorState<'Name>, value: seq<string>) : GlobalacceleratorCustomRoutingAcceleratorState<'Name> =
            state.assignments.Add(fun config -> config.IpAddresses <- (value |> Seq.toArray))
            state : GlobalacceleratorCustomRoutingAcceleratorState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_custom_routing_accelerator#ip_address_type-1">GlobalacceleratorCustomRoutingAccelerator#ip_address_type</a>.
        /// </summary>
        [<CustomOperation "ip_address_type">]
        member _.IpAddressType(state: GlobalacceleratorCustomRoutingAcceleratorState<'Name>, value: string) : GlobalacceleratorCustomRoutingAcceleratorState<'Name> =
            state.assignments.Add(fun config -> config.IpAddressType <- value)
            state : GlobalacceleratorCustomRoutingAcceleratorState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_custom_routing_accelerator#tags-1">GlobalacceleratorCustomRoutingAccelerator#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: GlobalacceleratorCustomRoutingAcceleratorState<'Name>, value: seq<string * string>) : GlobalacceleratorCustomRoutingAcceleratorState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : GlobalacceleratorCustomRoutingAcceleratorState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_custom_routing_accelerator#tags_all-1">GlobalacceleratorCustomRoutingAccelerator#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: GlobalacceleratorCustomRoutingAcceleratorState<'Name>, value: seq<string * string>) : GlobalacceleratorCustomRoutingAcceleratorState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : GlobalacceleratorCustomRoutingAcceleratorState<'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_custom_routing_accelerator#timeouts-1">GlobalacceleratorCustomRoutingAccelerator#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: GlobalacceleratorCustomRoutingAcceleratorState<'Name>, value: aws.GlobalacceleratorCustomRoutingAccelerator.GlobalacceleratorCustomRoutingAcceleratorTimeouts) : GlobalacceleratorCustomRoutingAcceleratorState<'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : GlobalacceleratorCustomRoutingAcceleratorState<'Name>

        member _.Run(state: GlobalacceleratorCustomRoutingAcceleratorState<Present>) : aws.GlobalacceleratorCustomRoutingAccelerator.GlobalacceleratorCustomRoutingAccelerator =
            let config = aws.GlobalacceleratorCustomRoutingAccelerator.GlobalacceleratorCustomRoutingAcceleratorConfig()
            for setter in state.assignments do
                setter config
            aws.GlobalacceleratorCustomRoutingAccelerator.GlobalacceleratorCustomRoutingAccelerator(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.globalacceleratorCustomRoutingAccelerator: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: GlobalacceleratorCustomRoutingAcceleratorState<_>) : aws.GlobalacceleratorCustomRoutingAccelerator.GlobalacceleratorCustomRoutingAccelerator =
            Unchecked.defaultof<aws.GlobalacceleratorCustomRoutingAccelerator.GlobalacceleratorCustomRoutingAccelerator>
