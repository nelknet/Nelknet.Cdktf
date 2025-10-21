namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RedshiftDataShareAuthorizationState<'ConsumerIdentifier, 'DataShareArn> = { assignments: ResizeArray<aws.RedshiftDataShareAuthorization.RedshiftDataShareAuthorizationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_data_share_authorization">aws_redshift_data_share_authorization</a>.
    /// </summary>
    type RedshiftDataShareAuthorizationBuilder(logicalId: string) =
        member _.Yield(_: unit) : RedshiftDataShareAuthorizationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RedshiftDataShareAuthorizationState<Missing, Missing>)

        member _.Zero(()) : RedshiftDataShareAuthorizationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RedshiftDataShareAuthorizationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_data_share_authorization#consumer_identifier-1">RedshiftDataShareAuthorization#consumer_identifier</a>.
        /// </summary>
        [<CustomOperation "consumer_identifier">]
        member _.ConsumerIdentifier(state: RedshiftDataShareAuthorizationState<Missing, 'DataShareArn>, value: string) : RedshiftDataShareAuthorizationState<Present, 'DataShareArn> =
            state.assignments.Add(fun config -> config.ConsumerIdentifier <- value)
            ({ assignments = state.assignments } : RedshiftDataShareAuthorizationState<Present, 'DataShareArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_data_share_authorization#data_share_arn-1">RedshiftDataShareAuthorization#data_share_arn</a>.
        /// </summary>
        [<CustomOperation "data_share_arn">]
        member _.DataShareArn(state: RedshiftDataShareAuthorizationState<'ConsumerIdentifier, Missing>, value: string) : RedshiftDataShareAuthorizationState<'ConsumerIdentifier, Present> =
            state.assignments.Add(fun config -> config.DataShareArn <- value)
            ({ assignments = state.assignments } : RedshiftDataShareAuthorizationState<'ConsumerIdentifier, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_data_share_authorization#allow_writes-1">RedshiftDataShareAuthorization#allow_writes</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "allow_writes">]
        member _.AllowWrites(state: RedshiftDataShareAuthorizationState<'ConsumerIdentifier, 'DataShareArn>, value: bool) : RedshiftDataShareAuthorizationState<'ConsumerIdentifier, 'DataShareArn> =
            state.assignments.Add(fun config -> config.AllowWrites <- value)
            state : RedshiftDataShareAuthorizationState<'ConsumerIdentifier, 'DataShareArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_data_share_authorization#allow_writes-1">RedshiftDataShareAuthorization#allow_writes</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "allow_writes">]
        member _.AllowWrites(state: RedshiftDataShareAuthorizationState<'ConsumerIdentifier, 'DataShareArn>, value: HashiCorp.Cdktf.IResolvable) : RedshiftDataShareAuthorizationState<'ConsumerIdentifier, 'DataShareArn> =
            state.assignments.Add(fun config -> config.AllowWrites <- value)
            state : RedshiftDataShareAuthorizationState<'ConsumerIdentifier, 'DataShareArn>

        member _.Run(state: RedshiftDataShareAuthorizationState<Present, Present>) : aws.RedshiftDataShareAuthorization.RedshiftDataShareAuthorization =
            let config = aws.RedshiftDataShareAuthorization.RedshiftDataShareAuthorizationConfig()
            for setter in state.assignments do
                setter config
            aws.RedshiftDataShareAuthorization.RedshiftDataShareAuthorization(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.redshiftDataShareAuthorization: missing required arguments. Must call: consumer_identifier, data_share_arn.", 9999, IsError = true)>]
        member _.Run(_: RedshiftDataShareAuthorizationState<_, _>) : aws.RedshiftDataShareAuthorization.RedshiftDataShareAuthorization =
            Unchecked.defaultof<aws.RedshiftDataShareAuthorization.RedshiftDataShareAuthorization>
