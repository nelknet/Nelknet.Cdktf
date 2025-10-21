namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RedshiftDataShareConsumerAssociationState<'DataShareArn> = { assignments: ResizeArray<aws.RedshiftDataShareConsumerAssociation.RedshiftDataShareConsumerAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_data_share_consumer_association">aws_redshift_data_share_consumer_association</a>.
    /// </summary>
    type RedshiftDataShareConsumerAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : RedshiftDataShareConsumerAssociationState<Missing> =
            ({ assignments = ResizeArray() } : RedshiftDataShareConsumerAssociationState<Missing>)

        member _.Zero(()) : RedshiftDataShareConsumerAssociationState<Missing> =
            ({ assignments = ResizeArray() } : RedshiftDataShareConsumerAssociationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_data_share_consumer_association#data_share_arn-1">RedshiftDataShareConsumerAssociation#data_share_arn</a>.
        /// </summary>
        [<CustomOperation "data_share_arn">]
        member _.DataShareArn(state: RedshiftDataShareConsumerAssociationState<Missing>, value: string) : RedshiftDataShareConsumerAssociationState<Present> =
            state.assignments.Add(fun config -> config.DataShareArn <- value)
            ({ assignments = state.assignments } : RedshiftDataShareConsumerAssociationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_data_share_consumer_association#allow_writes-1">RedshiftDataShareConsumerAssociation#allow_writes</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "allow_writes">]
        member _.AllowWrites(state: RedshiftDataShareConsumerAssociationState<'DataShareArn>, value: bool) : RedshiftDataShareConsumerAssociationState<'DataShareArn> =
            state.assignments.Add(fun config -> config.AllowWrites <- value)
            state : RedshiftDataShareConsumerAssociationState<'DataShareArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_data_share_consumer_association#allow_writes-1">RedshiftDataShareConsumerAssociation#allow_writes</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "allow_writes">]
        member _.AllowWrites(state: RedshiftDataShareConsumerAssociationState<'DataShareArn>, value: HashiCorp.Cdktf.IResolvable) : RedshiftDataShareConsumerAssociationState<'DataShareArn> =
            state.assignments.Add(fun config -> config.AllowWrites <- value)
            state : RedshiftDataShareConsumerAssociationState<'DataShareArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_data_share_consumer_association#associate_entire_account-1">RedshiftDataShareConsumerAssociation#associate_entire_account</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "associate_entire_account">]
        member _.AssociateEntireAccount(state: RedshiftDataShareConsumerAssociationState<'DataShareArn>, value: bool) : RedshiftDataShareConsumerAssociationState<'DataShareArn> =
            state.assignments.Add(fun config -> config.AssociateEntireAccount <- value)
            state : RedshiftDataShareConsumerAssociationState<'DataShareArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_data_share_consumer_association#associate_entire_account-1">RedshiftDataShareConsumerAssociation#associate_entire_account</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "associate_entire_account">]
        member _.AssociateEntireAccount(state: RedshiftDataShareConsumerAssociationState<'DataShareArn>, value: HashiCorp.Cdktf.IResolvable) : RedshiftDataShareConsumerAssociationState<'DataShareArn> =
            state.assignments.Add(fun config -> config.AssociateEntireAccount <- value)
            state : RedshiftDataShareConsumerAssociationState<'DataShareArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_data_share_consumer_association#consumer_arn-1">RedshiftDataShareConsumerAssociation#consumer_arn</a>.
        /// </summary>
        [<CustomOperation "consumer_arn">]
        member _.ConsumerArn(state: RedshiftDataShareConsumerAssociationState<'DataShareArn>, value: string) : RedshiftDataShareConsumerAssociationState<'DataShareArn> =
            state.assignments.Add(fun config -> config.ConsumerArn <- value)
            state : RedshiftDataShareConsumerAssociationState<'DataShareArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_data_share_consumer_association#consumer_region-1">RedshiftDataShareConsumerAssociation#consumer_region</a>.
        /// </summary>
        [<CustomOperation "consumer_region">]
        member _.ConsumerRegion(state: RedshiftDataShareConsumerAssociationState<'DataShareArn>, value: string) : RedshiftDataShareConsumerAssociationState<'DataShareArn> =
            state.assignments.Add(fun config -> config.ConsumerRegion <- value)
            state : RedshiftDataShareConsumerAssociationState<'DataShareArn>

        member _.Run(state: RedshiftDataShareConsumerAssociationState<Present>) : aws.RedshiftDataShareConsumerAssociation.RedshiftDataShareConsumerAssociation =
            let config = aws.RedshiftDataShareConsumerAssociation.RedshiftDataShareConsumerAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.RedshiftDataShareConsumerAssociation.RedshiftDataShareConsumerAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.redshiftDataShareConsumerAssociation: missing required arguments. Must call: data_share_arn.", 9999, IsError = true)>]
        member _.Run(_: RedshiftDataShareConsumerAssociationState<_>) : aws.RedshiftDataShareConsumerAssociation.RedshiftDataShareConsumerAssociation =
            Unchecked.defaultof<aws.RedshiftDataShareConsumerAssociation.RedshiftDataShareConsumerAssociation>
