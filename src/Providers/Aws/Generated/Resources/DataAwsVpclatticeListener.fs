namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsVpclatticeListenerState<'ListenerIdentifier, 'ServiceIdentifier> = { assignments: ResizeArray<aws.DataAwsVpclatticeListener.DataAwsVpclatticeListenerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpclattice_listener">aws_vpclattice_listener</a>.
    /// </summary>
    type DataAwsVpclatticeListenerBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsVpclatticeListenerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsVpclatticeListenerState<Missing, Missing>)

        member _.Zero(()) : DataAwsVpclatticeListenerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsVpclatticeListenerState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpclattice_listener#listener_identifier-1">DataAwsVpclatticeListener#listener_identifier</a>.
        /// </summary>
        [<CustomOperation "listener_identifier">]
        member _.ListenerIdentifier(state: DataAwsVpclatticeListenerState<Missing, 'ServiceIdentifier>, value: string) : DataAwsVpclatticeListenerState<Present, 'ServiceIdentifier> =
            state.assignments.Add(fun config -> config.ListenerIdentifier <- value)
            ({ assignments = state.assignments } : DataAwsVpclatticeListenerState<Present, 'ServiceIdentifier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpclattice_listener#service_identifier-1">DataAwsVpclatticeListener#service_identifier</a>.
        /// </summary>
        [<CustomOperation "service_identifier">]
        member _.ServiceIdentifier(state: DataAwsVpclatticeListenerState<'ListenerIdentifier, Missing>, value: string) : DataAwsVpclatticeListenerState<'ListenerIdentifier, Present> =
            state.assignments.Add(fun config -> config.ServiceIdentifier <- value)
            ({ assignments = state.assignments } : DataAwsVpclatticeListenerState<'ListenerIdentifier, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpclattice_listener#id-1">DataAwsVpclatticeListener#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsVpclatticeListenerState<'ListenerIdentifier, 'ServiceIdentifier>, value: string) : DataAwsVpclatticeListenerState<'ListenerIdentifier, 'ServiceIdentifier> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsVpclatticeListenerState<'ListenerIdentifier, 'ServiceIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpclattice_listener#tags-1">DataAwsVpclatticeListener#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsVpclatticeListenerState<'ListenerIdentifier, 'ServiceIdentifier>, value: seq<string * string>) : DataAwsVpclatticeListenerState<'ListenerIdentifier, 'ServiceIdentifier> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsVpclatticeListenerState<'ListenerIdentifier, 'ServiceIdentifier>

        member _.Run(state: DataAwsVpclatticeListenerState<Present, Present>) : aws.DataAwsVpclatticeListener.DataAwsVpclatticeListener =
            let config = aws.DataAwsVpclatticeListener.DataAwsVpclatticeListenerConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsVpclatticeListener.DataAwsVpclatticeListener(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsVpclatticeListener: missing required arguments. Must call: listener_identifier, service_identifier.", 9999, IsError = true)>]
        member _.Run(_: DataAwsVpclatticeListenerState<_, _>) : aws.DataAwsVpclatticeListener.DataAwsVpclatticeListener =
            Unchecked.defaultof<aws.DataAwsVpclatticeListener.DataAwsVpclatticeListener>
