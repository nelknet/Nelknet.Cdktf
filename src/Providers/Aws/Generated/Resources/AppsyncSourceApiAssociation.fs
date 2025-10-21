namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppsyncSourceApiAssociationState = { assignments: ResizeArray<aws.AppsyncSourceApiAssociation.AppsyncSourceApiAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_source_api_association">aws_appsync_source_api_association</a>.
    /// </summary>
    type AppsyncSourceApiAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppsyncSourceApiAssociationState =
            { assignments = ResizeArray() }

        member _.Zero(()) : AppsyncSourceApiAssociationState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_source_api_association#description-1">AppsyncSourceApiAssociation#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AppsyncSourceApiAssociationState, value: string) : AppsyncSourceApiAssociationState =
            state.assignments.Add(fun config -> config.Description <- value)
            state : AppsyncSourceApiAssociationState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_source_api_association#merged_api_arn-1">AppsyncSourceApiAssociation#merged_api_arn</a>.
        /// </summary>
        [<CustomOperation "merged_api_arn">]
        member _.MergedApiArn(state: AppsyncSourceApiAssociationState, value: string) : AppsyncSourceApiAssociationState =
            state.assignments.Add(fun config -> config.MergedApiArn <- value)
            state : AppsyncSourceApiAssociationState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_source_api_association#merged_api_id-1">AppsyncSourceApiAssociation#merged_api_id</a>.
        /// </summary>
        [<CustomOperation "merged_api_id">]
        member _.MergedApiId(state: AppsyncSourceApiAssociationState, value: string) : AppsyncSourceApiAssociationState =
            state.assignments.Add(fun config -> config.MergedApiId <- value)
            state : AppsyncSourceApiAssociationState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_source_api_association#source_api_arn-1">AppsyncSourceApiAssociation#source_api_arn</a>.
        /// </summary>
        [<CustomOperation "source_api_arn">]
        member _.SourceApiArn(state: AppsyncSourceApiAssociationState, value: string) : AppsyncSourceApiAssociationState =
            state.assignments.Add(fun config -> config.SourceApiArn <- value)
            state : AppsyncSourceApiAssociationState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_source_api_association#source_api_association_config-1">AppsyncSourceApiAssociation#source_api_association_config</a>. Accepts: aws.IResolvable | aws.AppsyncSourceApiAssociation.AppsyncSourceApiAssociationSourceApiAssociationConfig[]
        /// </summary>
        [<CustomOperation "source_api_association_config">]
        member _.SourceApiAssociationConfig(state: AppsyncSourceApiAssociationState, value: HashiCorp.Cdktf.IResolvable) : AppsyncSourceApiAssociationState =
            state.assignments.Add(fun config -> config.SourceApiAssociationConfig <- value)
            state : AppsyncSourceApiAssociationState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_source_api_association#source_api_id-1">AppsyncSourceApiAssociation#source_api_id</a>.
        /// </summary>
        [<CustomOperation "source_api_id">]
        member _.SourceApiId(state: AppsyncSourceApiAssociationState, value: string) : AppsyncSourceApiAssociationState =
            state.assignments.Add(fun config -> config.SourceApiId <- value)
            state : AppsyncSourceApiAssociationState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_source_api_association#timeouts-1">AppsyncSourceApiAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AppsyncSourceApiAssociationState, value: aws.AppsyncSourceApiAssociation.AppsyncSourceApiAssociationTimeouts) : AppsyncSourceApiAssociationState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AppsyncSourceApiAssociationState

        member _.Run(state: AppsyncSourceApiAssociationState) : aws.AppsyncSourceApiAssociation.AppsyncSourceApiAssociation =
            let config = aws.AppsyncSourceApiAssociation.AppsyncSourceApiAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.AppsyncSourceApiAssociation.AppsyncSourceApiAssociation(StackContext.get (), logicalId, config)
