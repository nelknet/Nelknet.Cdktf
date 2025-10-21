namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WafIpsetState<'Name> = { assignments: ResizeArray<aws.WafIpset.WafIpsetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_ipset">aws_waf_ipset</a>.
    /// </summary>
    type WafIpsetBuilder(logicalId: string) =
        member _.Yield(_: unit) : WafIpsetState<Missing> =
            ({ assignments = ResizeArray() } : WafIpsetState<Missing>)

        member _.Zero(()) : WafIpsetState<Missing> =
            ({ assignments = ResizeArray() } : WafIpsetState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_ipset#name-1">WafIpset#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: WafIpsetState<Missing>, value: string) : WafIpsetState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : WafIpsetState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_ipset#id-1">WafIpset#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: WafIpsetState<'Name>, value: string) : WafIpsetState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : WafIpsetState<'Name>

        /// <summary>
        /// ip_set_descriptors block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_ipset#ip_set_descriptors-1">WafIpset#ip_set_descriptors</a> Accepts: aws.IResolvable | aws.WafIpset.WafIpsetIpSetDescriptors[]
        /// </summary>
        [<CustomOperation "ip_set_descriptors">]
        member _.IpSetDescriptors(state: WafIpsetState<'Name>, value: HashiCorp.Cdktf.IResolvable) : WafIpsetState<'Name> =
            state.assignments.Add(fun config -> config.IpSetDescriptors <- value)
            state : WafIpsetState<'Name>

        member _.Run(state: WafIpsetState<Present>) : aws.WafIpset.WafIpset =
            let config = aws.WafIpset.WafIpsetConfig()
            for setter in state.assignments do
                setter config
            aws.WafIpset.WafIpset(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.wafIpset: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: WafIpsetState<_>) : aws.WafIpset.WafIpset =
            Unchecked.defaultof<aws.WafIpset.WafIpset>
