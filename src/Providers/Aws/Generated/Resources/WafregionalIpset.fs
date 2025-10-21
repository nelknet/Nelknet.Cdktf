namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WafregionalIpsetState<'Name> = { assignments: ResizeArray<aws.WafregionalIpset.WafregionalIpsetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_ipset">aws_wafregional_ipset</a>.
    /// </summary>
    type WafregionalIpsetBuilder(logicalId: string) =
        member _.Yield(_: unit) : WafregionalIpsetState<Missing> =
            ({ assignments = ResizeArray() } : WafregionalIpsetState<Missing>)

        member _.Zero(()) : WafregionalIpsetState<Missing> =
            ({ assignments = ResizeArray() } : WafregionalIpsetState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_ipset#name-1">WafregionalIpset#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: WafregionalIpsetState<Missing>, value: string) : WafregionalIpsetState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : WafregionalIpsetState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_ipset#id-1">WafregionalIpset#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: WafregionalIpsetState<'Name>, value: string) : WafregionalIpsetState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : WafregionalIpsetState<'Name>

        /// <summary>
        /// ip_set_descriptor block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_ipset#ip_set_descriptor-1">WafregionalIpset#ip_set_descriptor</a> Accepts: aws.IResolvable | aws.WafregionalIpset.WafregionalIpsetIpSetDescriptor[]
        /// </summary>
        [<CustomOperation "ip_set_descriptor">]
        member _.IpSetDescriptor(state: WafregionalIpsetState<'Name>, value: HashiCorp.Cdktf.IResolvable) : WafregionalIpsetState<'Name> =
            state.assignments.Add(fun config -> config.IpSetDescriptor <- value)
            state : WafregionalIpsetState<'Name>

        member _.Run(state: WafregionalIpsetState<Present>) : aws.WafregionalIpset.WafregionalIpset =
            let config = aws.WafregionalIpset.WafregionalIpsetConfig()
            for setter in state.assignments do
                setter config
            aws.WafregionalIpset.WafregionalIpset(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.wafregionalIpset: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: WafregionalIpsetState<_>) : aws.WafregionalIpset.WafregionalIpset =
            Unchecked.defaultof<aws.WafregionalIpset.WafregionalIpset>
