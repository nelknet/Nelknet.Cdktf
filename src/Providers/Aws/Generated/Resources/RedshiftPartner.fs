namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RedshiftPartnerState<'AccountId, 'ClusterIdentifier, 'DatabaseName, 'PartnerName> = { assignments: ResizeArray<aws.RedshiftPartner.RedshiftPartnerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_partner">aws_redshift_partner</a>.
    /// </summary>
    type RedshiftPartnerBuilder(logicalId: string) =
        member _.Yield(_: unit) : RedshiftPartnerState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RedshiftPartnerState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : RedshiftPartnerState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RedshiftPartnerState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_partner#account_id-1">RedshiftPartner#account_id</a>.
        /// </summary>
        [<CustomOperation "account_id">]
        member _.AccountId(state: RedshiftPartnerState<Missing, 'ClusterIdentifier, 'DatabaseName, 'PartnerName>, value: string) : RedshiftPartnerState<Present, 'ClusterIdentifier, 'DatabaseName, 'PartnerName> =
            state.assignments.Add(fun config -> config.AccountId <- value)
            ({ assignments = state.assignments } : RedshiftPartnerState<Present, 'ClusterIdentifier, 'DatabaseName, 'PartnerName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_partner#cluster_identifier-1">RedshiftPartner#cluster_identifier</a>.
        /// </summary>
        [<CustomOperation "cluster_identifier">]
        member _.ClusterIdentifier(state: RedshiftPartnerState<'AccountId, Missing, 'DatabaseName, 'PartnerName>, value: string) : RedshiftPartnerState<'AccountId, Present, 'DatabaseName, 'PartnerName> =
            state.assignments.Add(fun config -> config.ClusterIdentifier <- value)
            ({ assignments = state.assignments } : RedshiftPartnerState<'AccountId, Present, 'DatabaseName, 'PartnerName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_partner#database_name-1">RedshiftPartner#database_name</a>.
        /// </summary>
        [<CustomOperation "database_name">]
        member _.DatabaseName(state: RedshiftPartnerState<'AccountId, 'ClusterIdentifier, Missing, 'PartnerName>, value: string) : RedshiftPartnerState<'AccountId, 'ClusterIdentifier, Present, 'PartnerName> =
            state.assignments.Add(fun config -> config.DatabaseName <- value)
            ({ assignments = state.assignments } : RedshiftPartnerState<'AccountId, 'ClusterIdentifier, Present, 'PartnerName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_partner#partner_name-1">RedshiftPartner#partner_name</a>.
        /// </summary>
        [<CustomOperation "partner_name">]
        member _.PartnerName(state: RedshiftPartnerState<'AccountId, 'ClusterIdentifier, 'DatabaseName, Missing>, value: string) : RedshiftPartnerState<'AccountId, 'ClusterIdentifier, 'DatabaseName, Present> =
            state.assignments.Add(fun config -> config.PartnerName <- value)
            ({ assignments = state.assignments } : RedshiftPartnerState<'AccountId, 'ClusterIdentifier, 'DatabaseName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_partner#id-1">RedshiftPartner#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RedshiftPartnerState<'AccountId, 'ClusterIdentifier, 'DatabaseName, 'PartnerName>, value: string) : RedshiftPartnerState<'AccountId, 'ClusterIdentifier, 'DatabaseName, 'PartnerName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RedshiftPartnerState<'AccountId, 'ClusterIdentifier, 'DatabaseName, 'PartnerName>

        member _.Run(state: RedshiftPartnerState<Present, Present, Present, Present>) : aws.RedshiftPartner.RedshiftPartner =
            let config = aws.RedshiftPartner.RedshiftPartnerConfig()
            for setter in state.assignments do
                setter config
            aws.RedshiftPartner.RedshiftPartner(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.redshiftPartner: missing required arguments. Must call: account_id, cluster_identifier, database_name, partner_name.", 9999, IsError = true)>]
        member _.Run(_: RedshiftPartnerState<_, _, _, _>) : aws.RedshiftPartner.RedshiftPartner =
            Unchecked.defaultof<aws.RedshiftPartner.RedshiftPartner>
