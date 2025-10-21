namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpcIpamState<'OperatingRegions> = { assignments: ResizeArray<aws.VpcIpam.VpcIpamConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam">aws_vpc_ipam</a>.
    /// </summary>
    type VpcIpamBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpcIpamState<Missing> =
            ({ assignments = ResizeArray() } : VpcIpamState<Missing>)

        member _.Zero(()) : VpcIpamState<Missing> =
            ({ assignments = ResizeArray() } : VpcIpamState<Missing>)

        /// <summary>
        /// operating_regions block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam#operating_regions-1">VpcIpam#operating_regions</a> Accepts: aws.IResolvable | aws.VpcIpam.VpcIpamOperatingRegions[]
        /// </summary>
        [<CustomOperation "operating_regions">]
        member _.OperatingRegions(state: VpcIpamState<Missing>, value: HashiCorp.Cdktf.IResolvable) : VpcIpamState<Present> =
            state.assignments.Add(fun config -> config.OperatingRegions <- value)
            ({ assignments = state.assignments } : VpcIpamState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam#cascade-1">VpcIpam#cascade</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "cascade">]
        member _.Cascade(state: VpcIpamState<'OperatingRegions>, value: bool) : VpcIpamState<'OperatingRegions> =
            state.assignments.Add(fun config -> config.Cascade <- value)
            state : VpcIpamState<'OperatingRegions>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam#cascade-1">VpcIpam#cascade</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "cascade">]
        member _.Cascade(state: VpcIpamState<'OperatingRegions>, value: HashiCorp.Cdktf.IResolvable) : VpcIpamState<'OperatingRegions> =
            state.assignments.Add(fun config -> config.Cascade <- value)
            state : VpcIpamState<'OperatingRegions>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam#description-1">VpcIpam#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: VpcIpamState<'OperatingRegions>, value: string) : VpcIpamState<'OperatingRegions> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : VpcIpamState<'OperatingRegions>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam#enable_private_gua-1">VpcIpam#enable_private_gua</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_private_gua">]
        member _.EnablePrivateGua(state: VpcIpamState<'OperatingRegions>, value: bool) : VpcIpamState<'OperatingRegions> =
            state.assignments.Add(fun config -> config.EnablePrivateGua <- value)
            state : VpcIpamState<'OperatingRegions>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam#enable_private_gua-1">VpcIpam#enable_private_gua</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_private_gua">]
        member _.EnablePrivateGua(state: VpcIpamState<'OperatingRegions>, value: HashiCorp.Cdktf.IResolvable) : VpcIpamState<'OperatingRegions> =
            state.assignments.Add(fun config -> config.EnablePrivateGua <- value)
            state : VpcIpamState<'OperatingRegions>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam#id-1">VpcIpam#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpcIpamState<'OperatingRegions>, value: string) : VpcIpamState<'OperatingRegions> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpcIpamState<'OperatingRegions>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam#tags-1">VpcIpam#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VpcIpamState<'OperatingRegions>, value: seq<string * string>) : VpcIpamState<'OperatingRegions> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VpcIpamState<'OperatingRegions>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam#tags_all-1">VpcIpam#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: VpcIpamState<'OperatingRegions>, value: seq<string * string>) : VpcIpamState<'OperatingRegions> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : VpcIpamState<'OperatingRegions>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam#tier-1">VpcIpam#tier</a>.
        /// </summary>
        [<CustomOperation "tier">]
        member _.Tier(state: VpcIpamState<'OperatingRegions>, value: string) : VpcIpamState<'OperatingRegions> =
            state.assignments.Add(fun config -> config.Tier <- value)
            state : VpcIpamState<'OperatingRegions>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam#timeouts-1">VpcIpam#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VpcIpamState<'OperatingRegions>, value: aws.VpcIpam.VpcIpamTimeouts) : VpcIpamState<'OperatingRegions> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VpcIpamState<'OperatingRegions>

        member _.Run(state: VpcIpamState<Present>) : aws.VpcIpam.VpcIpam =
            let config = aws.VpcIpam.VpcIpamConfig()
            for setter in state.assignments do
                setter config
            aws.VpcIpam.VpcIpam(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpcIpam: missing required arguments. Must call: operating_regions.", 9999, IsError = true)>]
        member _.Run(_: VpcIpamState<_>) : aws.VpcIpam.VpcIpam =
            Unchecked.defaultof<aws.VpcIpam.VpcIpam>
