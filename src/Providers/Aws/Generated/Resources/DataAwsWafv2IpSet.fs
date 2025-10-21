namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsWafv2IpSetState<'Name, 'Scope> = { assignments: ResizeArray<aws.DataAwsWafv2IpSet.DataAwsWafv2IpSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/wafv2_ip_set">aws_wafv2_ip_set</a>.
    /// </summary>
    type DataAwsWafv2IpSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsWafv2IpSetState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsWafv2IpSetState<Missing, Missing>)

        member _.Zero(()) : DataAwsWafv2IpSetState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsWafv2IpSetState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/wafv2_ip_set#name-1">DataAwsWafv2IpSet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsWafv2IpSetState<Missing, 'Scope>, value: string) : DataAwsWafv2IpSetState<Present, 'Scope> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsWafv2IpSetState<Present, 'Scope>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/wafv2_ip_set#scope-1">DataAwsWafv2IpSet#scope</a>.
        /// </summary>
        [<CustomOperation "scope">]
        member _.Scope(state: DataAwsWafv2IpSetState<'Name, Missing>, value: string) : DataAwsWafv2IpSetState<'Name, Present> =
            state.assignments.Add(fun config -> config.Scope <- value)
            ({ assignments = state.assignments } : DataAwsWafv2IpSetState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/wafv2_ip_set#id-1">DataAwsWafv2IpSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsWafv2IpSetState<'Name, 'Scope>, value: string) : DataAwsWafv2IpSetState<'Name, 'Scope> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsWafv2IpSetState<'Name, 'Scope>

        member _.Run(state: DataAwsWafv2IpSetState<Present, Present>) : aws.DataAwsWafv2IpSet.DataAwsWafv2IpSet =
            let config = aws.DataAwsWafv2IpSet.DataAwsWafv2IpSetConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsWafv2IpSet.DataAwsWafv2IpSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsWafv2IpSet: missing required arguments. Must call: name, scope.", 9999, IsError = true)>]
        member _.Run(_: DataAwsWafv2IpSetState<_, _>) : aws.DataAwsWafv2IpSet.DataAwsWafv2IpSet =
            Unchecked.defaultof<aws.DataAwsWafv2IpSet.DataAwsWafv2IpSet>
