namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EipState = { assignments: ResizeArray<aws.Eip.EipConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eip">aws_eip</a>.
    /// </summary>
    type EipBuilder(logicalId: string) =
        member _.Yield(_: unit) : EipState =
            { assignments = ResizeArray() }

        member _.Zero(()) : EipState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eip#address-1">Eip#address</a>.
        /// </summary>
        [<CustomOperation "address">]
        member _.Address(state: EipState, value: string) : EipState =
            state.assignments.Add(fun config -> config.Address <- value)
            state : EipState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eip#associate_with_private_ip-1">Eip#associate_with_private_ip</a>.
        /// </summary>
        [<CustomOperation "associate_with_private_ip">]
        member _.AssociateWithPrivateIp(state: EipState, value: string) : EipState =
            state.assignments.Add(fun config -> config.AssociateWithPrivateIp <- value)
            state : EipState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eip#customer_owned_ipv4_pool-1">Eip#customer_owned_ipv4_pool</a>.
        /// </summary>
        [<CustomOperation "customer_owned_ipv4_pool">]
        member _.CustomerOwnedIpv4Pool(state: EipState, value: string) : EipState =
            state.assignments.Add(fun config -> config.CustomerOwnedIpv4Pool <- value)
            state : EipState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eip#domain-1">Eip#domain</a>.
        /// </summary>
        [<CustomOperation "domain">]
        member _.Domain(state: EipState, value: string) : EipState =
            state.assignments.Add(fun config -> config.Domain <- value)
            state : EipState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eip#id-1">Eip#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EipState, value: string) : EipState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EipState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eip#instance-1">Eip#instance</a>.
        /// </summary>
        [<CustomOperation "instance">]
        member _.Instance(state: EipState, value: string) : EipState =
            state.assignments.Add(fun config -> config.Instance <- value)
            state : EipState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eip#ipam_pool_id-1">Eip#ipam_pool_id</a>.
        /// </summary>
        [<CustomOperation "ipam_pool_id">]
        member _.IpamPoolId(state: EipState, value: string) : EipState =
            state.assignments.Add(fun config -> config.IpamPoolId <- value)
            state : EipState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eip#network_border_group-1">Eip#network_border_group</a>.
        /// </summary>
        [<CustomOperation "network_border_group">]
        member _.NetworkBorderGroup(state: EipState, value: string) : EipState =
            state.assignments.Add(fun config -> config.NetworkBorderGroup <- value)
            state : EipState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eip#network_interface-1">Eip#network_interface</a>.
        /// </summary>
        [<CustomOperation "network_interface">]
        member _.NetworkInterface(state: EipState, value: string) : EipState =
            state.assignments.Add(fun config -> config.NetworkInterface <- value)
            state : EipState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eip#public_ipv4_pool-1">Eip#public_ipv4_pool</a>.
        /// </summary>
        [<CustomOperation "public_ipv4_pool">]
        member _.PublicIpv4Pool(state: EipState, value: string) : EipState =
            state.assignments.Add(fun config -> config.PublicIpv4Pool <- value)
            state : EipState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eip#tags-1">Eip#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: EipState, value: seq<string * string>) : EipState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : EipState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eip#tags_all-1">Eip#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: EipState, value: seq<string * string>) : EipState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : EipState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eip#timeouts-1">Eip#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: EipState, value: aws.Eip.EipTimeouts) : EipState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : EipState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eip#vpc-1">Eip#vpc</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "vpc">]
        member _.Vpc(state: EipState, value: bool) : EipState =
            state.assignments.Add(fun config -> config.Vpc <- value)
            state : EipState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eip#vpc-1">Eip#vpc</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "vpc">]
        member _.Vpc(state: EipState, value: HashiCorp.Cdktf.IResolvable) : EipState =
            state.assignments.Add(fun config -> config.Vpc <- value)
            state : EipState

        member _.Run(state: EipState) : aws.Eip.Eip =
            let config = aws.Eip.EipConfig()
            for setter in state.assignments do
                setter config
            aws.Eip.Eip(StackContext.get (), logicalId, config)
