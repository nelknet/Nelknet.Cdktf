namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MskScramSecretAssociationState<'ClusterArn, 'SecretArnList> = { assignments: ResizeArray<aws.MskScramSecretAssociation.MskScramSecretAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_scram_secret_association">aws_msk_scram_secret_association</a>.
    /// </summary>
    type MskScramSecretAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : MskScramSecretAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : MskScramSecretAssociationState<Missing, Missing>)

        member _.Zero(()) : MskScramSecretAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : MskScramSecretAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_scram_secret_association#cluster_arn-1">MskScramSecretAssociation#cluster_arn</a>.
        /// </summary>
        [<CustomOperation "cluster_arn">]
        member _.ClusterArn(state: MskScramSecretAssociationState<Missing, 'SecretArnList>, value: string) : MskScramSecretAssociationState<Present, 'SecretArnList> =
            state.assignments.Add(fun config -> config.ClusterArn <- value)
            ({ assignments = state.assignments } : MskScramSecretAssociationState<Present, 'SecretArnList>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_scram_secret_association#secret_arn_list-1">MskScramSecretAssociation#secret_arn_list</a>.
        /// </summary>
        [<CustomOperation "secret_arn_list">]
        member _.SecretArnList(state: MskScramSecretAssociationState<'ClusterArn, Missing>, value: seq<string>) : MskScramSecretAssociationState<'ClusterArn, Present> =
            state.assignments.Add(fun config -> config.SecretArnList <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : MskScramSecretAssociationState<'ClusterArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_scram_secret_association#id-1">MskScramSecretAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MskScramSecretAssociationState<'ClusterArn, 'SecretArnList>, value: string) : MskScramSecretAssociationState<'ClusterArn, 'SecretArnList> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MskScramSecretAssociationState<'ClusterArn, 'SecretArnList>

        member _.Run(state: MskScramSecretAssociationState<Present, Present>) : aws.MskScramSecretAssociation.MskScramSecretAssociation =
            let config = aws.MskScramSecretAssociation.MskScramSecretAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.MskScramSecretAssociation.MskScramSecretAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.mskScramSecretAssociation: missing required arguments. Must call: cluster_arn, secret_arn_list.", 9999, IsError = true)>]
        member _.Run(_: MskScramSecretAssociationState<_, _>) : aws.MskScramSecretAssociation.MskScramSecretAssociation =
            Unchecked.defaultof<aws.MskScramSecretAssociation.MskScramSecretAssociation>
