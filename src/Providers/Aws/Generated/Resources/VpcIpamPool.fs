namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpcIpamPoolState<'AddressFamily, 'IpamScopeId> = { assignments: ResizeArray<aws.VpcIpamPool.VpcIpamPoolConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_pool">aws_vpc_ipam_pool</a>.
    /// </summary>
    type VpcIpamPoolBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpcIpamPoolState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpcIpamPoolState<Missing, Missing>)

        member _.Zero(()) : VpcIpamPoolState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpcIpamPoolState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_pool#address_family-1">VpcIpamPool#address_family</a>.
        /// </summary>
        [<CustomOperation "address_family">]
        member _.AddressFamily(state: VpcIpamPoolState<Missing, 'IpamScopeId>, value: string) : VpcIpamPoolState<Present, 'IpamScopeId> =
            state.assignments.Add(fun config -> config.AddressFamily <- value)
            ({ assignments = state.assignments } : VpcIpamPoolState<Present, 'IpamScopeId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_pool#ipam_scope_id-1">VpcIpamPool#ipam_scope_id</a>.
        /// </summary>
        [<CustomOperation "ipam_scope_id">]
        member _.IpamScopeId(state: VpcIpamPoolState<'AddressFamily, Missing>, value: string) : VpcIpamPoolState<'AddressFamily, Present> =
            state.assignments.Add(fun config -> config.IpamScopeId <- value)
            ({ assignments = state.assignments } : VpcIpamPoolState<'AddressFamily, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_pool#allocation_default_netmask_length-1">VpcIpamPool#allocation_default_netmask_length</a>.
        /// </summary>
        [<CustomOperation "allocation_default_netmask_length">]
        member _.AllocationDefaultNetmaskLength(state: VpcIpamPoolState<'AddressFamily, 'IpamScopeId>, value: double) : VpcIpamPoolState<'AddressFamily, 'IpamScopeId> =
            state.assignments.Add(fun config -> config.AllocationDefaultNetmaskLength <- value)
            state : VpcIpamPoolState<'AddressFamily, 'IpamScopeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_pool#allocation_max_netmask_length-1">VpcIpamPool#allocation_max_netmask_length</a>.
        /// </summary>
        [<CustomOperation "allocation_max_netmask_length">]
        member _.AllocationMaxNetmaskLength(state: VpcIpamPoolState<'AddressFamily, 'IpamScopeId>, value: double) : VpcIpamPoolState<'AddressFamily, 'IpamScopeId> =
            state.assignments.Add(fun config -> config.AllocationMaxNetmaskLength <- value)
            state : VpcIpamPoolState<'AddressFamily, 'IpamScopeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_pool#allocation_min_netmask_length-1">VpcIpamPool#allocation_min_netmask_length</a>.
        /// </summary>
        [<CustomOperation "allocation_min_netmask_length">]
        member _.AllocationMinNetmaskLength(state: VpcIpamPoolState<'AddressFamily, 'IpamScopeId>, value: double) : VpcIpamPoolState<'AddressFamily, 'IpamScopeId> =
            state.assignments.Add(fun config -> config.AllocationMinNetmaskLength <- value)
            state : VpcIpamPoolState<'AddressFamily, 'IpamScopeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_pool#allocation_resource_tags-1">VpcIpamPool#allocation_resource_tags</a>.
        /// </summary>
        [<CustomOperation "allocation_resource_tags">]
        member _.AllocationResourceTags(state: VpcIpamPoolState<'AddressFamily, 'IpamScopeId>, value: seq<string * string>) : VpcIpamPoolState<'AddressFamily, 'IpamScopeId> =
            state.assignments.Add(fun config -> config.AllocationResourceTags <- dict value)
            state : VpcIpamPoolState<'AddressFamily, 'IpamScopeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_pool#auto_import-1">VpcIpamPool#auto_import</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_import">]
        member _.AutoImport(state: VpcIpamPoolState<'AddressFamily, 'IpamScopeId>, value: bool) : VpcIpamPoolState<'AddressFamily, 'IpamScopeId> =
            state.assignments.Add(fun config -> config.AutoImport <- value)
            state : VpcIpamPoolState<'AddressFamily, 'IpamScopeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_pool#auto_import-1">VpcIpamPool#auto_import</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_import">]
        member _.AutoImport(state: VpcIpamPoolState<'AddressFamily, 'IpamScopeId>, value: HashiCorp.Cdktf.IResolvable) : VpcIpamPoolState<'AddressFamily, 'IpamScopeId> =
            state.assignments.Add(fun config -> config.AutoImport <- value)
            state : VpcIpamPoolState<'AddressFamily, 'IpamScopeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_pool#aws_service-1">VpcIpamPool#aws_service</a>.
        /// </summary>
        [<CustomOperation "aws_service">]
        member _.AwsService(state: VpcIpamPoolState<'AddressFamily, 'IpamScopeId>, value: string) : VpcIpamPoolState<'AddressFamily, 'IpamScopeId> =
            state.assignments.Add(fun config -> config.AwsService <- value)
            state : VpcIpamPoolState<'AddressFamily, 'IpamScopeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_pool#cascade-1">VpcIpamPool#cascade</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "cascade">]
        member _.Cascade(state: VpcIpamPoolState<'AddressFamily, 'IpamScopeId>, value: bool) : VpcIpamPoolState<'AddressFamily, 'IpamScopeId> =
            state.assignments.Add(fun config -> config.Cascade <- value)
            state : VpcIpamPoolState<'AddressFamily, 'IpamScopeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_pool#cascade-1">VpcIpamPool#cascade</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "cascade">]
        member _.Cascade(state: VpcIpamPoolState<'AddressFamily, 'IpamScopeId>, value: HashiCorp.Cdktf.IResolvable) : VpcIpamPoolState<'AddressFamily, 'IpamScopeId> =
            state.assignments.Add(fun config -> config.Cascade <- value)
            state : VpcIpamPoolState<'AddressFamily, 'IpamScopeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_pool#description-1">VpcIpamPool#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: VpcIpamPoolState<'AddressFamily, 'IpamScopeId>, value: string) : VpcIpamPoolState<'AddressFamily, 'IpamScopeId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : VpcIpamPoolState<'AddressFamily, 'IpamScopeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_pool#id-1">VpcIpamPool#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpcIpamPoolState<'AddressFamily, 'IpamScopeId>, value: string) : VpcIpamPoolState<'AddressFamily, 'IpamScopeId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpcIpamPoolState<'AddressFamily, 'IpamScopeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_pool#locale-1">VpcIpamPool#locale</a>.
        /// </summary>
        [<CustomOperation "locale">]
        member _.Locale(state: VpcIpamPoolState<'AddressFamily, 'IpamScopeId>, value: string) : VpcIpamPoolState<'AddressFamily, 'IpamScopeId> =
            state.assignments.Add(fun config -> config.Locale <- value)
            state : VpcIpamPoolState<'AddressFamily, 'IpamScopeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_pool#public_ip_source-1">VpcIpamPool#public_ip_source</a>.
        /// </summary>
        [<CustomOperation "public_ip_source">]
        member _.PublicIpSource(state: VpcIpamPoolState<'AddressFamily, 'IpamScopeId>, value: string) : VpcIpamPoolState<'AddressFamily, 'IpamScopeId> =
            state.assignments.Add(fun config -> config.PublicIpSource <- value)
            state : VpcIpamPoolState<'AddressFamily, 'IpamScopeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_pool#publicly_advertisable-1">VpcIpamPool#publicly_advertisable</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "publicly_advertisable">]
        member _.PubliclyAdvertisable(state: VpcIpamPoolState<'AddressFamily, 'IpamScopeId>, value: bool) : VpcIpamPoolState<'AddressFamily, 'IpamScopeId> =
            state.assignments.Add(fun config -> config.PubliclyAdvertisable <- value)
            state : VpcIpamPoolState<'AddressFamily, 'IpamScopeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_pool#publicly_advertisable-1">VpcIpamPool#publicly_advertisable</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "publicly_advertisable">]
        member _.PubliclyAdvertisable(state: VpcIpamPoolState<'AddressFamily, 'IpamScopeId>, value: HashiCorp.Cdktf.IResolvable) : VpcIpamPoolState<'AddressFamily, 'IpamScopeId> =
            state.assignments.Add(fun config -> config.PubliclyAdvertisable <- value)
            state : VpcIpamPoolState<'AddressFamily, 'IpamScopeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_pool#source_ipam_pool_id-1">VpcIpamPool#source_ipam_pool_id</a>.
        /// </summary>
        [<CustomOperation "source_ipam_pool_id">]
        member _.SourceIpamPoolId(state: VpcIpamPoolState<'AddressFamily, 'IpamScopeId>, value: string) : VpcIpamPoolState<'AddressFamily, 'IpamScopeId> =
            state.assignments.Add(fun config -> config.SourceIpamPoolId <- value)
            state : VpcIpamPoolState<'AddressFamily, 'IpamScopeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_pool#tags-1">VpcIpamPool#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VpcIpamPoolState<'AddressFamily, 'IpamScopeId>, value: seq<string * string>) : VpcIpamPoolState<'AddressFamily, 'IpamScopeId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VpcIpamPoolState<'AddressFamily, 'IpamScopeId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_pool#tags_all-1">VpcIpamPool#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: VpcIpamPoolState<'AddressFamily, 'IpamScopeId>, value: seq<string * string>) : VpcIpamPoolState<'AddressFamily, 'IpamScopeId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : VpcIpamPoolState<'AddressFamily, 'IpamScopeId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_pool#timeouts-1">VpcIpamPool#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VpcIpamPoolState<'AddressFamily, 'IpamScopeId>, value: aws.VpcIpamPool.VpcIpamPoolTimeouts) : VpcIpamPoolState<'AddressFamily, 'IpamScopeId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VpcIpamPoolState<'AddressFamily, 'IpamScopeId>

        member _.Run(state: VpcIpamPoolState<Present, Present>) : aws.VpcIpamPool.VpcIpamPool =
            let config = aws.VpcIpamPool.VpcIpamPoolConfig()
            for setter in state.assignments do
                setter config
            aws.VpcIpamPool.VpcIpamPool(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpcIpamPool: missing required arguments. Must call: address_family, ipam_scope_id.", 9999, IsError = true)>]
        member _.Run(_: VpcIpamPoolState<_, _>) : aws.VpcIpamPool.VpcIpamPool =
            Unchecked.defaultof<aws.VpcIpamPool.VpcIpamPool>
