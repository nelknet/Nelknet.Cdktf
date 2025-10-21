namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpclatticeListenerState<'DefaultAction, 'Name, 'Protocol> = { assignments: ResizeArray<aws.VpclatticeListener.VpclatticeListenerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener">aws_vpclattice_listener</a>.
    /// </summary>
    type VpclatticeListenerBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpclatticeListenerState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VpclatticeListenerState<Missing, Missing, Missing>)

        member _.Zero(()) : VpclatticeListenerState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VpclatticeListenerState<Missing, Missing, Missing>)

        /// <summary>
        /// default_action block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener#default_action-1">VpclatticeListener#default_action</a>
        /// </summary>
        [<CustomOperation "default_action">]
        member _.DefaultAction(state: VpclatticeListenerState<Missing, 'Name, 'Protocol>, value: aws.VpclatticeListener.VpclatticeListenerDefaultAction) : VpclatticeListenerState<Present, 'Name, 'Protocol> =
            state.assignments.Add(fun config -> config.DefaultAction <- value)
            ({ assignments = state.assignments } : VpclatticeListenerState<Present, 'Name, 'Protocol>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener#name-1">VpclatticeListener#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VpclatticeListenerState<'DefaultAction, Missing, 'Protocol>, value: string) : VpclatticeListenerState<'DefaultAction, Present, 'Protocol> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VpclatticeListenerState<'DefaultAction, Present, 'Protocol>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener#protocol-1">VpclatticeListener#protocol</a>.
        /// </summary>
        [<CustomOperation "protocol">]
        member _.Protocol(state: VpclatticeListenerState<'DefaultAction, 'Name, Missing>, value: string) : VpclatticeListenerState<'DefaultAction, 'Name, Present> =
            state.assignments.Add(fun config -> config.Protocol <- value)
            ({ assignments = state.assignments } : VpclatticeListenerState<'DefaultAction, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener#id-1">VpclatticeListener#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpclatticeListenerState<'DefaultAction, 'Name, 'Protocol>, value: string) : VpclatticeListenerState<'DefaultAction, 'Name, 'Protocol> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpclatticeListenerState<'DefaultAction, 'Name, 'Protocol>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener#port-1">VpclatticeListener#port</a>.
        /// </summary>
        [<CustomOperation "port">]
        member _.Port(state: VpclatticeListenerState<'DefaultAction, 'Name, 'Protocol>, value: double) : VpclatticeListenerState<'DefaultAction, 'Name, 'Protocol> =
            state.assignments.Add(fun config -> config.Port <- value)
            state : VpclatticeListenerState<'DefaultAction, 'Name, 'Protocol>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener#service_arn-1">VpclatticeListener#service_arn</a>.
        /// </summary>
        [<CustomOperation "service_arn">]
        member _.ServiceArn(state: VpclatticeListenerState<'DefaultAction, 'Name, 'Protocol>, value: string) : VpclatticeListenerState<'DefaultAction, 'Name, 'Protocol> =
            state.assignments.Add(fun config -> config.ServiceArn <- value)
            state : VpclatticeListenerState<'DefaultAction, 'Name, 'Protocol>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener#service_identifier-1">VpclatticeListener#service_identifier</a>.
        /// </summary>
        [<CustomOperation "service_identifier">]
        member _.ServiceIdentifier(state: VpclatticeListenerState<'DefaultAction, 'Name, 'Protocol>, value: string) : VpclatticeListenerState<'DefaultAction, 'Name, 'Protocol> =
            state.assignments.Add(fun config -> config.ServiceIdentifier <- value)
            state : VpclatticeListenerState<'DefaultAction, 'Name, 'Protocol>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener#tags-1">VpclatticeListener#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VpclatticeListenerState<'DefaultAction, 'Name, 'Protocol>, value: seq<string * string>) : VpclatticeListenerState<'DefaultAction, 'Name, 'Protocol> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VpclatticeListenerState<'DefaultAction, 'Name, 'Protocol>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener#tags_all-1">VpclatticeListener#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: VpclatticeListenerState<'DefaultAction, 'Name, 'Protocol>, value: seq<string * string>) : VpclatticeListenerState<'DefaultAction, 'Name, 'Protocol> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : VpclatticeListenerState<'DefaultAction, 'Name, 'Protocol>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener#timeouts-1">VpclatticeListener#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VpclatticeListenerState<'DefaultAction, 'Name, 'Protocol>, value: aws.VpclatticeListener.VpclatticeListenerTimeouts) : VpclatticeListenerState<'DefaultAction, 'Name, 'Protocol> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VpclatticeListenerState<'DefaultAction, 'Name, 'Protocol>

        member _.Run(state: VpclatticeListenerState<Present, Present, Present>) : aws.VpclatticeListener.VpclatticeListener =
            let config = aws.VpclatticeListener.VpclatticeListenerConfig()
            for setter in state.assignments do
                setter config
            aws.VpclatticeListener.VpclatticeListener(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpclatticeListener: missing required arguments. Must call: default_action, name, protocol.", 9999, IsError = true)>]
        member _.Run(_: VpclatticeListenerState<_, _, _>) : aws.VpclatticeListener.VpclatticeListener =
            Unchecked.defaultof<aws.VpclatticeListener.VpclatticeListener>
