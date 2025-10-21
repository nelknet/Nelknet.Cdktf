namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DefaultNetworkAclState<'DefaultNetworkAclId> = { assignments: ResizeArray<aws.DefaultNetworkAcl.DefaultNetworkAclConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_network_acl">aws_default_network_acl</a>.
    /// </summary>
    type DefaultNetworkAclBuilder(logicalId: string) =
        member _.Yield(_: unit) : DefaultNetworkAclState<Missing> =
            ({ assignments = ResizeArray() } : DefaultNetworkAclState<Missing>)

        member _.Zero(()) : DefaultNetworkAclState<Missing> =
            ({ assignments = ResizeArray() } : DefaultNetworkAclState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_network_acl#default_network_acl_id-1">DefaultNetworkAcl#default_network_acl_id</a>.
        /// </summary>
        [<CustomOperation "default_network_acl_id">]
        member _.DefaultNetworkAclId(state: DefaultNetworkAclState<Missing>, value: string) : DefaultNetworkAclState<Present> =
            state.assignments.Add(fun config -> config.DefaultNetworkAclId <- value)
            ({ assignments = state.assignments } : DefaultNetworkAclState<Present>)

        /// <summary>
        /// egress block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_network_acl#egress-1">DefaultNetworkAcl#egress</a> Accepts: aws.IResolvable | aws.DefaultNetworkAcl.DefaultNetworkAclEgress[]
        /// </summary>
        [<CustomOperation "egress">]
        member _.Egress(state: DefaultNetworkAclState<'DefaultNetworkAclId>, value: HashiCorp.Cdktf.IResolvable) : DefaultNetworkAclState<'DefaultNetworkAclId> =
            state.assignments.Add(fun config -> config.Egress <- value)
            state : DefaultNetworkAclState<'DefaultNetworkAclId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_network_acl#id-1">DefaultNetworkAcl#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DefaultNetworkAclState<'DefaultNetworkAclId>, value: string) : DefaultNetworkAclState<'DefaultNetworkAclId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DefaultNetworkAclState<'DefaultNetworkAclId>

        /// <summary>
        /// ingress block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_network_acl#ingress-1">DefaultNetworkAcl#ingress</a> Accepts: aws.IResolvable | aws.DefaultNetworkAcl.DefaultNetworkAclIngress[]
        /// </summary>
        [<CustomOperation "ingress">]
        member _.Ingress(state: DefaultNetworkAclState<'DefaultNetworkAclId>, value: HashiCorp.Cdktf.IResolvable) : DefaultNetworkAclState<'DefaultNetworkAclId> =
            state.assignments.Add(fun config -> config.Ingress <- value)
            state : DefaultNetworkAclState<'DefaultNetworkAclId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_network_acl#subnet_ids-1">DefaultNetworkAcl#subnet_ids</a>.
        /// </summary>
        [<CustomOperation "subnet_ids">]
        member _.SubnetIds(state: DefaultNetworkAclState<'DefaultNetworkAclId>, value: seq<string>) : DefaultNetworkAclState<'DefaultNetworkAclId> =
            state.assignments.Add(fun config -> config.SubnetIds <- (value |> Seq.toArray))
            state : DefaultNetworkAclState<'DefaultNetworkAclId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_network_acl#tags-1">DefaultNetworkAcl#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DefaultNetworkAclState<'DefaultNetworkAclId>, value: seq<string * string>) : DefaultNetworkAclState<'DefaultNetworkAclId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DefaultNetworkAclState<'DefaultNetworkAclId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_network_acl#tags_all-1">DefaultNetworkAcl#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DefaultNetworkAclState<'DefaultNetworkAclId>, value: seq<string * string>) : DefaultNetworkAclState<'DefaultNetworkAclId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DefaultNetworkAclState<'DefaultNetworkAclId>

        member _.Run(state: DefaultNetworkAclState<Present>) : aws.DefaultNetworkAcl.DefaultNetworkAcl =
            let config = aws.DefaultNetworkAcl.DefaultNetworkAclConfig()
            for setter in state.assignments do
                setter config
            aws.DefaultNetworkAcl.DefaultNetworkAcl(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.defaultNetworkAcl: missing required arguments. Must call: default_network_acl_id.", 9999, IsError = true)>]
        member _.Run(_: DefaultNetworkAclState<_>) : aws.DefaultNetworkAcl.DefaultNetworkAcl =
            Unchecked.defaultof<aws.DefaultNetworkAcl.DefaultNetworkAcl>
