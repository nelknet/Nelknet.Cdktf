namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WafregionalWebAclAssociationState<'ResourceArn, 'WebAclId> = { assignments: ResizeArray<aws.WafregionalWebAclAssociation.WafregionalWebAclAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_web_acl_association">aws_wafregional_web_acl_association</a>.
    /// </summary>
    type WafregionalWebAclAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : WafregionalWebAclAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : WafregionalWebAclAssociationState<Missing, Missing>)

        member _.Zero(()) : WafregionalWebAclAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : WafregionalWebAclAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_web_acl_association#resource_arn-1">WafregionalWebAclAssociation#resource_arn</a>.
        /// </summary>
        [<CustomOperation "resource_arn">]
        member _.ResourceArn(state: WafregionalWebAclAssociationState<Missing, 'WebAclId>, value: string) : WafregionalWebAclAssociationState<Present, 'WebAclId> =
            state.assignments.Add(fun config -> config.ResourceArn <- value)
            ({ assignments = state.assignments } : WafregionalWebAclAssociationState<Present, 'WebAclId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_web_acl_association#web_acl_id-1">WafregionalWebAclAssociation#web_acl_id</a>.
        /// </summary>
        [<CustomOperation "web_acl_id">]
        member _.WebAclId(state: WafregionalWebAclAssociationState<'ResourceArn, Missing>, value: string) : WafregionalWebAclAssociationState<'ResourceArn, Present> =
            state.assignments.Add(fun config -> config.WebAclId <- value)
            ({ assignments = state.assignments } : WafregionalWebAclAssociationState<'ResourceArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_web_acl_association#id-1">WafregionalWebAclAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: WafregionalWebAclAssociationState<'ResourceArn, 'WebAclId>, value: string) : WafregionalWebAclAssociationState<'ResourceArn, 'WebAclId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : WafregionalWebAclAssociationState<'ResourceArn, 'WebAclId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_web_acl_association#timeouts-1">WafregionalWebAclAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: WafregionalWebAclAssociationState<'ResourceArn, 'WebAclId>, value: aws.WafregionalWebAclAssociation.WafregionalWebAclAssociationTimeouts) : WafregionalWebAclAssociationState<'ResourceArn, 'WebAclId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : WafregionalWebAclAssociationState<'ResourceArn, 'WebAclId>

        member _.Run(state: WafregionalWebAclAssociationState<Present, Present>) : aws.WafregionalWebAclAssociation.WafregionalWebAclAssociation =
            let config = aws.WafregionalWebAclAssociation.WafregionalWebAclAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.WafregionalWebAclAssociation.WafregionalWebAclAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.wafregionalWebAclAssociation: missing required arguments. Must call: resource_arn, web_acl_id.", 9999, IsError = true)>]
        member _.Run(_: WafregionalWebAclAssociationState<_, _>) : aws.WafregionalWebAclAssociation.WafregionalWebAclAssociation =
            Unchecked.defaultof<aws.WafregionalWebAclAssociation.WafregionalWebAclAssociation>
