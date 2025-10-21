namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GlobalacceleratorAcceleratorState<'Name> = { assignments: ResizeArray<aws.GlobalacceleratorAccelerator.GlobalacceleratorAcceleratorConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_accelerator">aws_globalaccelerator_accelerator</a>.
    /// </summary>
    type GlobalacceleratorAcceleratorBuilder(logicalId: string) =
        member _.Yield(_: unit) : GlobalacceleratorAcceleratorState<Missing> =
            ({ assignments = ResizeArray() } : GlobalacceleratorAcceleratorState<Missing>)

        member _.Zero(()) : GlobalacceleratorAcceleratorState<Missing> =
            ({ assignments = ResizeArray() } : GlobalacceleratorAcceleratorState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_accelerator#name-1">GlobalacceleratorAccelerator#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: GlobalacceleratorAcceleratorState<Missing>, value: string) : GlobalacceleratorAcceleratorState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : GlobalacceleratorAcceleratorState<Present>)

        /// <summary>
        /// attributes block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_accelerator#attributes-1">GlobalacceleratorAccelerator#attributes</a>
        /// </summary>
        [<CustomOperation "attributes">]
        member _.Attributes(state: GlobalacceleratorAcceleratorState<'Name>, value: aws.GlobalacceleratorAccelerator.GlobalacceleratorAcceleratorAttributes) : GlobalacceleratorAcceleratorState<'Name> =
            state.assignments.Add(fun config -> config.Attributes <- value)
            state : GlobalacceleratorAcceleratorState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_accelerator#enabled-1">GlobalacceleratorAccelerator#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: GlobalacceleratorAcceleratorState<'Name>, value: bool) : GlobalacceleratorAcceleratorState<'Name> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : GlobalacceleratorAcceleratorState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_accelerator#enabled-1">GlobalacceleratorAccelerator#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: GlobalacceleratorAcceleratorState<'Name>, value: HashiCorp.Cdktf.IResolvable) : GlobalacceleratorAcceleratorState<'Name> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : GlobalacceleratorAcceleratorState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_accelerator#id-1">GlobalacceleratorAccelerator#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GlobalacceleratorAcceleratorState<'Name>, value: string) : GlobalacceleratorAcceleratorState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GlobalacceleratorAcceleratorState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_accelerator#ip_addresses-1">GlobalacceleratorAccelerator#ip_addresses</a>.
        /// </summary>
        [<CustomOperation "ip_addresses">]
        member _.IpAddresses(state: GlobalacceleratorAcceleratorState<'Name>, value: seq<string>) : GlobalacceleratorAcceleratorState<'Name> =
            state.assignments.Add(fun config -> config.IpAddresses <- (value |> Seq.toArray))
            state : GlobalacceleratorAcceleratorState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_accelerator#ip_address_type-1">GlobalacceleratorAccelerator#ip_address_type</a>.
        /// </summary>
        [<CustomOperation "ip_address_type">]
        member _.IpAddressType(state: GlobalacceleratorAcceleratorState<'Name>, value: string) : GlobalacceleratorAcceleratorState<'Name> =
            state.assignments.Add(fun config -> config.IpAddressType <- value)
            state : GlobalacceleratorAcceleratorState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_accelerator#tags-1">GlobalacceleratorAccelerator#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: GlobalacceleratorAcceleratorState<'Name>, value: seq<string * string>) : GlobalacceleratorAcceleratorState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : GlobalacceleratorAcceleratorState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_accelerator#tags_all-1">GlobalacceleratorAccelerator#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: GlobalacceleratorAcceleratorState<'Name>, value: seq<string * string>) : GlobalacceleratorAcceleratorState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : GlobalacceleratorAcceleratorState<'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_accelerator#timeouts-1">GlobalacceleratorAccelerator#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: GlobalacceleratorAcceleratorState<'Name>, value: aws.GlobalacceleratorAccelerator.GlobalacceleratorAcceleratorTimeouts) : GlobalacceleratorAcceleratorState<'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : GlobalacceleratorAcceleratorState<'Name>

        member _.Run(state: GlobalacceleratorAcceleratorState<Present>) : aws.GlobalacceleratorAccelerator.GlobalacceleratorAccelerator =
            let config = aws.GlobalacceleratorAccelerator.GlobalacceleratorAcceleratorConfig()
            for setter in state.assignments do
                setter config
            aws.GlobalacceleratorAccelerator.GlobalacceleratorAccelerator(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.globalacceleratorAccelerator: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: GlobalacceleratorAcceleratorState<_>) : aws.GlobalacceleratorAccelerator.GlobalacceleratorAccelerator =
            Unchecked.defaultof<aws.GlobalacceleratorAccelerator.GlobalacceleratorAccelerator>
