namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsWafregionalIpsetState<'Name> = { assignments: ResizeArray<aws.DataAwsWafregionalIpset.DataAwsWafregionalIpsetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/wafregional_ipset">aws_wafregional_ipset</a>.
    /// </summary>
    type DataAwsWafregionalIpsetBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsWafregionalIpsetState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsWafregionalIpsetState<Missing>)

        member _.Zero(()) : DataAwsWafregionalIpsetState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsWafregionalIpsetState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/wafregional_ipset#name-1">DataAwsWafregionalIpset#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsWafregionalIpsetState<Missing>, value: string) : DataAwsWafregionalIpsetState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsWafregionalIpsetState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/wafregional_ipset#id-1">DataAwsWafregionalIpset#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsWafregionalIpsetState<'Name>, value: string) : DataAwsWafregionalIpsetState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsWafregionalIpsetState<'Name>

        member _.Run(state: DataAwsWafregionalIpsetState<Present>) : aws.DataAwsWafregionalIpset.DataAwsWafregionalIpset =
            let config = aws.DataAwsWafregionalIpset.DataAwsWafregionalIpsetConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsWafregionalIpset.DataAwsWafregionalIpset(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsWafregionalIpset: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsWafregionalIpsetState<_>) : aws.DataAwsWafregionalIpset.DataAwsWafregionalIpset =
            Unchecked.defaultof<aws.DataAwsWafregionalIpset.DataAwsWafregionalIpset>
