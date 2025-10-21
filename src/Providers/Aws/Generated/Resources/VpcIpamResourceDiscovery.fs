namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpcIpamResourceDiscoveryState<'OperatingRegions> = { assignments: ResizeArray<aws.VpcIpamResourceDiscovery.VpcIpamResourceDiscoveryConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_resource_discovery">aws_vpc_ipam_resource_discovery</a>.
    /// </summary>
    type VpcIpamResourceDiscoveryBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpcIpamResourceDiscoveryState<Missing> =
            ({ assignments = ResizeArray() } : VpcIpamResourceDiscoveryState<Missing>)

        member _.Zero(()) : VpcIpamResourceDiscoveryState<Missing> =
            ({ assignments = ResizeArray() } : VpcIpamResourceDiscoveryState<Missing>)

        /// <summary>
        /// operating_regions block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_resource_discovery#operating_regions-1">VpcIpamResourceDiscovery#operating_regions</a> Accepts: aws.IResolvable | aws.VpcIpamResourceDiscovery.VpcIpamResourceDiscoveryOperatingRegions[]
        /// </summary>
        [<CustomOperation "operating_regions">]
        member _.OperatingRegions(state: VpcIpamResourceDiscoveryState<Missing>, value: HashiCorp.Cdktf.IResolvable) : VpcIpamResourceDiscoveryState<Present> =
            state.assignments.Add(fun config -> config.OperatingRegions <- value)
            ({ assignments = state.assignments } : VpcIpamResourceDiscoveryState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_resource_discovery#description-1">VpcIpamResourceDiscovery#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: VpcIpamResourceDiscoveryState<'OperatingRegions>, value: string) : VpcIpamResourceDiscoveryState<'OperatingRegions> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : VpcIpamResourceDiscoveryState<'OperatingRegions>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_resource_discovery#id-1">VpcIpamResourceDiscovery#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpcIpamResourceDiscoveryState<'OperatingRegions>, value: string) : VpcIpamResourceDiscoveryState<'OperatingRegions> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpcIpamResourceDiscoveryState<'OperatingRegions>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_resource_discovery#tags-1">VpcIpamResourceDiscovery#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VpcIpamResourceDiscoveryState<'OperatingRegions>, value: seq<string * string>) : VpcIpamResourceDiscoveryState<'OperatingRegions> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VpcIpamResourceDiscoveryState<'OperatingRegions>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_resource_discovery#tags_all-1">VpcIpamResourceDiscovery#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: VpcIpamResourceDiscoveryState<'OperatingRegions>, value: seq<string * string>) : VpcIpamResourceDiscoveryState<'OperatingRegions> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : VpcIpamResourceDiscoveryState<'OperatingRegions>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_resource_discovery#timeouts-1">VpcIpamResourceDiscovery#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VpcIpamResourceDiscoveryState<'OperatingRegions>, value: aws.VpcIpamResourceDiscovery.VpcIpamResourceDiscoveryTimeouts) : VpcIpamResourceDiscoveryState<'OperatingRegions> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VpcIpamResourceDiscoveryState<'OperatingRegions>

        member _.Run(state: VpcIpamResourceDiscoveryState<Present>) : aws.VpcIpamResourceDiscovery.VpcIpamResourceDiscovery =
            let config = aws.VpcIpamResourceDiscovery.VpcIpamResourceDiscoveryConfig()
            for setter in state.assignments do
                setter config
            aws.VpcIpamResourceDiscovery.VpcIpamResourceDiscovery(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpcIpamResourceDiscovery: missing required arguments. Must call: operating_regions.", 9999, IsError = true)>]
        member _.Run(_: VpcIpamResourceDiscoveryState<_>) : aws.VpcIpamResourceDiscovery.VpcIpamResourceDiscovery =
            Unchecked.defaultof<aws.VpcIpamResourceDiscovery.VpcIpamResourceDiscovery>
