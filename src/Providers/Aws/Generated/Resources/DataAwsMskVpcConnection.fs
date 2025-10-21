namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsMskVpcConnectionState<'Arn> = { assignments: ResizeArray<aws.DataAwsMskVpcConnection.DataAwsMskVpcConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/msk_vpc_connection">aws_msk_vpc_connection</a>.
    /// </summary>
    type DataAwsMskVpcConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsMskVpcConnectionState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsMskVpcConnectionState<Missing>)

        member _.Zero(()) : DataAwsMskVpcConnectionState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsMskVpcConnectionState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/msk_vpc_connection#arn-1">DataAwsMskVpcConnection#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: DataAwsMskVpcConnectionState<Missing>, value: string) : DataAwsMskVpcConnectionState<Present> =
            state.assignments.Add(fun config -> config.Arn <- value)
            ({ assignments = state.assignments } : DataAwsMskVpcConnectionState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/msk_vpc_connection#id-1">DataAwsMskVpcConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsMskVpcConnectionState<'Arn>, value: string) : DataAwsMskVpcConnectionState<'Arn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsMskVpcConnectionState<'Arn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/msk_vpc_connection#tags-1">DataAwsMskVpcConnection#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsMskVpcConnectionState<'Arn>, value: seq<string * string>) : DataAwsMskVpcConnectionState<'Arn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsMskVpcConnectionState<'Arn>

        member _.Run(state: DataAwsMskVpcConnectionState<Present>) : aws.DataAwsMskVpcConnection.DataAwsMskVpcConnection =
            let config = aws.DataAwsMskVpcConnection.DataAwsMskVpcConnectionConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsMskVpcConnection.DataAwsMskVpcConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsMskVpcConnection: missing required arguments. Must call: arn.", 9999, IsError = true)>]
        member _.Run(_: DataAwsMskVpcConnectionState<_>) : aws.DataAwsMskVpcConnection.DataAwsMskVpcConnection =
            Unchecked.defaultof<aws.DataAwsMskVpcConnection.DataAwsMskVpcConnection>
