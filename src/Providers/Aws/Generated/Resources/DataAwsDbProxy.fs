namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsDbProxyState<'Name> = { assignments: ResizeArray<aws.DataAwsDbProxy.DataAwsDbProxyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/db_proxy">aws_db_proxy</a>.
    /// </summary>
    type DataAwsDbProxyBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsDbProxyState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsDbProxyState<Missing>)

        member _.Zero(()) : DataAwsDbProxyState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsDbProxyState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/db_proxy#name-1">DataAwsDbProxy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsDbProxyState<Missing>, value: string) : DataAwsDbProxyState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsDbProxyState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/db_proxy#id-1">DataAwsDbProxy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsDbProxyState<'Name>, value: string) : DataAwsDbProxyState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsDbProxyState<'Name>

        member _.Run(state: DataAwsDbProxyState<Present>) : aws.DataAwsDbProxy.DataAwsDbProxy =
            let config = aws.DataAwsDbProxy.DataAwsDbProxyConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsDbProxy.DataAwsDbProxy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsDbProxy: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsDbProxyState<_>) : aws.DataAwsDbProxy.DataAwsDbProxy =
            Unchecked.defaultof<aws.DataAwsDbProxy.DataAwsDbProxy>
