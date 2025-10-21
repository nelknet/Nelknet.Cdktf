namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsWafIpsetState<'Name> = { assignments: ResizeArray<aws.DataAwsWafIpset.DataAwsWafIpsetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/waf_ipset">aws_waf_ipset</a>.
    /// </summary>
    type DataAwsWafIpsetBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsWafIpsetState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsWafIpsetState<Missing>)

        member _.Zero(()) : DataAwsWafIpsetState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsWafIpsetState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/waf_ipset#name-1">DataAwsWafIpset#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsWafIpsetState<Missing>, value: string) : DataAwsWafIpsetState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsWafIpsetState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/waf_ipset#id-1">DataAwsWafIpset#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsWafIpsetState<'Name>, value: string) : DataAwsWafIpsetState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsWafIpsetState<'Name>

        member _.Run(state: DataAwsWafIpsetState<Present>) : aws.DataAwsWafIpset.DataAwsWafIpset =
            let config = aws.DataAwsWafIpset.DataAwsWafIpsetConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsWafIpset.DataAwsWafIpset(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsWafIpset: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsWafIpsetState<_>) : aws.DataAwsWafIpset.DataAwsWafIpset =
            Unchecked.defaultof<aws.DataAwsWafIpset.DataAwsWafIpset>
