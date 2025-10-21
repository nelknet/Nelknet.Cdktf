namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Wafv2WebAclAssociationState<'ResourceArn, 'WebAclArn> = { assignments: ResizeArray<aws.Wafv2WebAclAssociation.Wafv2WebAclAssociationConfigA -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl_association">aws_wafv2_web_acl_association</a>.
    /// </summary>
    type Wafv2WebAclAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : Wafv2WebAclAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Wafv2WebAclAssociationState<Missing, Missing>)

        member _.Zero(()) : Wafv2WebAclAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Wafv2WebAclAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl_association#resource_arn-1">Wafv2WebAclAssociation#resource_arn</a>.
        /// </summary>
        [<CustomOperation "resource_arn">]
        member _.ResourceArn(state: Wafv2WebAclAssociationState<Missing, 'WebAclArn>, value: string) : Wafv2WebAclAssociationState<Present, 'WebAclArn> =
            state.assignments.Add(fun config -> config.ResourceArn <- value)
            ({ assignments = state.assignments } : Wafv2WebAclAssociationState<Present, 'WebAclArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl_association#web_acl_arn-1">Wafv2WebAclAssociation#web_acl_arn</a>.
        /// </summary>
        [<CustomOperation "web_acl_arn">]
        member _.WebAclArn(state: Wafv2WebAclAssociationState<'ResourceArn, Missing>, value: string) : Wafv2WebAclAssociationState<'ResourceArn, Present> =
            state.assignments.Add(fun config -> config.WebAclArn <- value)
            ({ assignments = state.assignments } : Wafv2WebAclAssociationState<'ResourceArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl_association#id-1">Wafv2WebAclAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Wafv2WebAclAssociationState<'ResourceArn, 'WebAclArn>, value: string) : Wafv2WebAclAssociationState<'ResourceArn, 'WebAclArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Wafv2WebAclAssociationState<'ResourceArn, 'WebAclArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl_association#timeouts-1">Wafv2WebAclAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Wafv2WebAclAssociationState<'ResourceArn, 'WebAclArn>, value: aws.Wafv2WebAclAssociation.Wafv2WebAclAssociationTimeouts) : Wafv2WebAclAssociationState<'ResourceArn, 'WebAclArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Wafv2WebAclAssociationState<'ResourceArn, 'WebAclArn>

        member _.Run(state: Wafv2WebAclAssociationState<Present, Present>) : aws.Wafv2WebAclAssociation.Wafv2WebAclAssociation =
            let config = aws.Wafv2WebAclAssociation.Wafv2WebAclAssociationConfigA()
            for setter in state.assignments do
                setter config
            aws.Wafv2WebAclAssociation.Wafv2WebAclAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.wafv2WebAclAssociation: missing required arguments. Must call: resource_arn, web_acl_arn.", 9999, IsError = true)>]
        member _.Run(_: Wafv2WebAclAssociationState<_, _>) : aws.Wafv2WebAclAssociation.Wafv2WebAclAssociation =
            Unchecked.defaultof<aws.Wafv2WebAclAssociation.Wafv2WebAclAssociation>
