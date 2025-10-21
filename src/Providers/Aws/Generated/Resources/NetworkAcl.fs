namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkAclState<'VpcId> = { assignments: ResizeArray<aws.NetworkAcl.NetworkAclConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_acl">aws_network_acl</a>.
    /// </summary>
    type NetworkAclBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkAclState<Missing> =
            ({ assignments = ResizeArray() } : NetworkAclState<Missing>)

        member _.Zero(()) : NetworkAclState<Missing> =
            ({ assignments = ResizeArray() } : NetworkAclState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_acl#vpc_id-1">NetworkAcl#vpc_id</a>.
        /// </summary>
        [<CustomOperation "vpc_id">]
        member _.VpcId(state: NetworkAclState<Missing>, value: string) : NetworkAclState<Present> =
            state.assignments.Add(fun config -> config.VpcId <- value)
            ({ assignments = state.assignments } : NetworkAclState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_acl#egress-1">NetworkAcl#egress</a>. Accepts: aws.IResolvable | aws.NetworkAcl.NetworkAclEgress[]
        /// </summary>
        [<CustomOperation "egress">]
        member _.Egress(state: NetworkAclState<'VpcId>, value: HashiCorp.Cdktf.IResolvable) : NetworkAclState<'VpcId> =
            state.assignments.Add(fun config -> config.Egress <- value)
            state : NetworkAclState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_acl#id-1">NetworkAcl#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkAclState<'VpcId>, value: string) : NetworkAclState<'VpcId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkAclState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_acl#ingress-1">NetworkAcl#ingress</a>. Accepts: aws.IResolvable | aws.NetworkAcl.NetworkAclIngress[]
        /// </summary>
        [<CustomOperation "ingress">]
        member _.Ingress(state: NetworkAclState<'VpcId>, value: HashiCorp.Cdktf.IResolvable) : NetworkAclState<'VpcId> =
            state.assignments.Add(fun config -> config.Ingress <- value)
            state : NetworkAclState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_acl#subnet_ids-1">NetworkAcl#subnet_ids</a>.
        /// </summary>
        [<CustomOperation "subnet_ids">]
        member _.SubnetIds(state: NetworkAclState<'VpcId>, value: seq<string>) : NetworkAclState<'VpcId> =
            state.assignments.Add(fun config -> config.SubnetIds <- (value |> Seq.toArray))
            state : NetworkAclState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_acl#tags-1">NetworkAcl#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NetworkAclState<'VpcId>, value: seq<string * string>) : NetworkAclState<'VpcId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NetworkAclState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/network_acl#tags_all-1">NetworkAcl#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: NetworkAclState<'VpcId>, value: seq<string * string>) : NetworkAclState<'VpcId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : NetworkAclState<'VpcId>

        member _.Run(state: NetworkAclState<Present>) : aws.NetworkAcl.NetworkAcl =
            let config = aws.NetworkAcl.NetworkAclConfig()
            for setter in state.assignments do
                setter config
            aws.NetworkAcl.NetworkAcl(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.networkAcl: missing required arguments. Must call: vpc_id.", 9999, IsError = true)>]
        member _.Run(_: NetworkAclState<_>) : aws.NetworkAcl.NetworkAcl =
            Unchecked.defaultof<aws.NetworkAcl.NetworkAcl>
