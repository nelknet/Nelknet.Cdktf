namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MskSingleScramSecretAssociationState<'ClusterArn, 'SecretArn> = { assignments: ResizeArray<aws.MskSingleScramSecretAssociation.MskSingleScramSecretAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_single_scram_secret_association">aws_msk_single_scram_secret_association</a>.
    /// </summary>
    type MskSingleScramSecretAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : MskSingleScramSecretAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : MskSingleScramSecretAssociationState<Missing, Missing>)

        member _.Zero(()) : MskSingleScramSecretAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : MskSingleScramSecretAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_single_scram_secret_association#cluster_arn-1">MskSingleScramSecretAssociation#cluster_arn</a>.
        /// </summary>
        [<CustomOperation "cluster_arn">]
        member _.ClusterArn(state: MskSingleScramSecretAssociationState<Missing, 'SecretArn>, value: string) : MskSingleScramSecretAssociationState<Present, 'SecretArn> =
            state.assignments.Add(fun config -> config.ClusterArn <- value)
            ({ assignments = state.assignments } : MskSingleScramSecretAssociationState<Present, 'SecretArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_single_scram_secret_association#secret_arn-1">MskSingleScramSecretAssociation#secret_arn</a>.
        /// </summary>
        [<CustomOperation "secret_arn">]
        member _.SecretArn(state: MskSingleScramSecretAssociationState<'ClusterArn, Missing>, value: string) : MskSingleScramSecretAssociationState<'ClusterArn, Present> =
            state.assignments.Add(fun config -> config.SecretArn <- value)
            ({ assignments = state.assignments } : MskSingleScramSecretAssociationState<'ClusterArn, Present>)

        member _.Run(state: MskSingleScramSecretAssociationState<Present, Present>) : aws.MskSingleScramSecretAssociation.MskSingleScramSecretAssociation =
            let config = aws.MskSingleScramSecretAssociation.MskSingleScramSecretAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.MskSingleScramSecretAssociation.MskSingleScramSecretAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.mskSingleScramSecretAssociation: missing required arguments. Must call: cluster_arn, secret_arn.", 9999, IsError = true)>]
        member _.Run(_: MskSingleScramSecretAssociationState<_, _>) : aws.MskSingleScramSecretAssociation.MskSingleScramSecretAssociation =
            Unchecked.defaultof<aws.MskSingleScramSecretAssociation.MskSingleScramSecretAssociation>
