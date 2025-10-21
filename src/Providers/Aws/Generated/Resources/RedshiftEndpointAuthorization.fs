namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RedshiftEndpointAuthorizationState<'Account, 'ClusterIdentifier> = { assignments: ResizeArray<aws.RedshiftEndpointAuthorization.RedshiftEndpointAuthorizationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_endpoint_authorization">aws_redshift_endpoint_authorization</a>.
    /// </summary>
    type RedshiftEndpointAuthorizationBuilder(logicalId: string) =
        member _.Yield(_: unit) : RedshiftEndpointAuthorizationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RedshiftEndpointAuthorizationState<Missing, Missing>)

        member _.Zero(()) : RedshiftEndpointAuthorizationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RedshiftEndpointAuthorizationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_endpoint_authorization#account-1">RedshiftEndpointAuthorization#account</a>.
        /// </summary>
        [<CustomOperation "account">]
        member _.Account(state: RedshiftEndpointAuthorizationState<Missing, 'ClusterIdentifier>, value: string) : RedshiftEndpointAuthorizationState<Present, 'ClusterIdentifier> =
            state.assignments.Add(fun config -> config.Account <- value)
            ({ assignments = state.assignments } : RedshiftEndpointAuthorizationState<Present, 'ClusterIdentifier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_endpoint_authorization#cluster_identifier-1">RedshiftEndpointAuthorization#cluster_identifier</a>.
        /// </summary>
        [<CustomOperation "cluster_identifier">]
        member _.ClusterIdentifier(state: RedshiftEndpointAuthorizationState<'Account, Missing>, value: string) : RedshiftEndpointAuthorizationState<'Account, Present> =
            state.assignments.Add(fun config -> config.ClusterIdentifier <- value)
            ({ assignments = state.assignments } : RedshiftEndpointAuthorizationState<'Account, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_endpoint_authorization#force_delete-1">RedshiftEndpointAuthorization#force_delete</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_delete">]
        member _.ForceDelete(state: RedshiftEndpointAuthorizationState<'Account, 'ClusterIdentifier>, value: bool) : RedshiftEndpointAuthorizationState<'Account, 'ClusterIdentifier> =
            state.assignments.Add(fun config -> config.ForceDelete <- value)
            state : RedshiftEndpointAuthorizationState<'Account, 'ClusterIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_endpoint_authorization#force_delete-1">RedshiftEndpointAuthorization#force_delete</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_delete">]
        member _.ForceDelete(state: RedshiftEndpointAuthorizationState<'Account, 'ClusterIdentifier>, value: HashiCorp.Cdktf.IResolvable) : RedshiftEndpointAuthorizationState<'Account, 'ClusterIdentifier> =
            state.assignments.Add(fun config -> config.ForceDelete <- value)
            state : RedshiftEndpointAuthorizationState<'Account, 'ClusterIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_endpoint_authorization#id-1">RedshiftEndpointAuthorization#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RedshiftEndpointAuthorizationState<'Account, 'ClusterIdentifier>, value: string) : RedshiftEndpointAuthorizationState<'Account, 'ClusterIdentifier> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RedshiftEndpointAuthorizationState<'Account, 'ClusterIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_endpoint_authorization#vpc_ids-1">RedshiftEndpointAuthorization#vpc_ids</a>.
        /// </summary>
        [<CustomOperation "vpc_ids">]
        member _.VpcIds(state: RedshiftEndpointAuthorizationState<'Account, 'ClusterIdentifier>, value: seq<string>) : RedshiftEndpointAuthorizationState<'Account, 'ClusterIdentifier> =
            state.assignments.Add(fun config -> config.VpcIds <- (value |> Seq.toArray))
            state : RedshiftEndpointAuthorizationState<'Account, 'ClusterIdentifier>

        member _.Run(state: RedshiftEndpointAuthorizationState<Present, Present>) : aws.RedshiftEndpointAuthorization.RedshiftEndpointAuthorization =
            let config = aws.RedshiftEndpointAuthorization.RedshiftEndpointAuthorizationConfig()
            for setter in state.assignments do
                setter config
            aws.RedshiftEndpointAuthorization.RedshiftEndpointAuthorization(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.redshiftEndpointAuthorization: missing required arguments. Must call: account, cluster_identifier.", 9999, IsError = true)>]
        member _.Run(_: RedshiftEndpointAuthorizationState<_, _>) : aws.RedshiftEndpointAuthorization.RedshiftEndpointAuthorization =
            Unchecked.defaultof<aws.RedshiftEndpointAuthorization.RedshiftEndpointAuthorization>
