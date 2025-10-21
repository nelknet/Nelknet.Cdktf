namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsNetworkmanagerDevicesState<'GlobalNetworkId> = { assignments: ResizeArray<aws.DataAwsNetworkmanagerDevices.DataAwsNetworkmanagerDevicesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_devices">aws_networkmanager_devices</a>.
    /// </summary>
    type DataAwsNetworkmanagerDevicesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsNetworkmanagerDevicesState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsNetworkmanagerDevicesState<Missing>)

        member _.Zero(()) : DataAwsNetworkmanagerDevicesState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsNetworkmanagerDevicesState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_devices#global_network_id-1">DataAwsNetworkmanagerDevices#global_network_id</a>.
        /// </summary>
        [<CustomOperation "global_network_id">]
        member _.GlobalNetworkId(state: DataAwsNetworkmanagerDevicesState<Missing>, value: string) : DataAwsNetworkmanagerDevicesState<Present> =
            state.assignments.Add(fun config -> config.GlobalNetworkId <- value)
            ({ assignments = state.assignments } : DataAwsNetworkmanagerDevicesState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_devices#id-1">DataAwsNetworkmanagerDevices#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsNetworkmanagerDevicesState<'GlobalNetworkId>, value: string) : DataAwsNetworkmanagerDevicesState<'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsNetworkmanagerDevicesState<'GlobalNetworkId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_devices#site_id-1">DataAwsNetworkmanagerDevices#site_id</a>.
        /// </summary>
        [<CustomOperation "site_id">]
        member _.SiteId(state: DataAwsNetworkmanagerDevicesState<'GlobalNetworkId>, value: string) : DataAwsNetworkmanagerDevicesState<'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.SiteId <- value)
            state : DataAwsNetworkmanagerDevicesState<'GlobalNetworkId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/networkmanager_devices#tags-1">DataAwsNetworkmanagerDevices#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsNetworkmanagerDevicesState<'GlobalNetworkId>, value: seq<string * string>) : DataAwsNetworkmanagerDevicesState<'GlobalNetworkId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsNetworkmanagerDevicesState<'GlobalNetworkId>

        member _.Run(state: DataAwsNetworkmanagerDevicesState<Present>) : aws.DataAwsNetworkmanagerDevices.DataAwsNetworkmanagerDevices =
            let config = aws.DataAwsNetworkmanagerDevices.DataAwsNetworkmanagerDevicesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsNetworkmanagerDevices.DataAwsNetworkmanagerDevices(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsNetworkmanagerDevices: missing required arguments. Must call: global_network_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsNetworkmanagerDevicesState<_>) : aws.DataAwsNetworkmanagerDevices.DataAwsNetworkmanagerDevices =
            Unchecked.defaultof<aws.DataAwsNetworkmanagerDevices.DataAwsNetworkmanagerDevices>
