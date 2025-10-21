namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RedshiftHsmConfigurationState<'Description, 'HsmConfigurationIdentifier, 'HsmIpAddress, 'HsmPartitionName, 'HsmPartitionPassword, 'HsmServerPublicCertificate> = { assignments: ResizeArray<aws.RedshiftHsmConfiguration.RedshiftHsmConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_hsm_configuration">aws_redshift_hsm_configuration</a>.
    /// </summary>
    type RedshiftHsmConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : RedshiftHsmConfigurationState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RedshiftHsmConfigurationState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : RedshiftHsmConfigurationState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RedshiftHsmConfigurationState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_hsm_configuration#description-1">RedshiftHsmConfiguration#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: RedshiftHsmConfigurationState<Missing, 'HsmConfigurationIdentifier, 'HsmIpAddress, 'HsmPartitionName, 'HsmPartitionPassword, 'HsmServerPublicCertificate>, value: string) : RedshiftHsmConfigurationState<Present, 'HsmConfigurationIdentifier, 'HsmIpAddress, 'HsmPartitionName, 'HsmPartitionPassword, 'HsmServerPublicCertificate> =
            state.assignments.Add(fun config -> config.Description <- value)
            ({ assignments = state.assignments } : RedshiftHsmConfigurationState<Present, 'HsmConfigurationIdentifier, 'HsmIpAddress, 'HsmPartitionName, 'HsmPartitionPassword, 'HsmServerPublicCertificate>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_hsm_configuration#hsm_configuration_identifier-1">RedshiftHsmConfiguration#hsm_configuration_identifier</a>.
        /// </summary>
        [<CustomOperation "hsm_configuration_identifier">]
        member _.HsmConfigurationIdentifier(state: RedshiftHsmConfigurationState<'Description, Missing, 'HsmIpAddress, 'HsmPartitionName, 'HsmPartitionPassword, 'HsmServerPublicCertificate>, value: string) : RedshiftHsmConfigurationState<'Description, Present, 'HsmIpAddress, 'HsmPartitionName, 'HsmPartitionPassword, 'HsmServerPublicCertificate> =
            state.assignments.Add(fun config -> config.HsmConfigurationIdentifier <- value)
            ({ assignments = state.assignments } : RedshiftHsmConfigurationState<'Description, Present, 'HsmIpAddress, 'HsmPartitionName, 'HsmPartitionPassword, 'HsmServerPublicCertificate>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_hsm_configuration#hsm_ip_address-1">RedshiftHsmConfiguration#hsm_ip_address</a>.
        /// </summary>
        [<CustomOperation "hsm_ip_address">]
        member _.HsmIpAddress(state: RedshiftHsmConfigurationState<'Description, 'HsmConfigurationIdentifier, Missing, 'HsmPartitionName, 'HsmPartitionPassword, 'HsmServerPublicCertificate>, value: string) : RedshiftHsmConfigurationState<'Description, 'HsmConfigurationIdentifier, Present, 'HsmPartitionName, 'HsmPartitionPassword, 'HsmServerPublicCertificate> =
            state.assignments.Add(fun config -> config.HsmIpAddress <- value)
            ({ assignments = state.assignments } : RedshiftHsmConfigurationState<'Description, 'HsmConfigurationIdentifier, Present, 'HsmPartitionName, 'HsmPartitionPassword, 'HsmServerPublicCertificate>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_hsm_configuration#hsm_partition_name-1">RedshiftHsmConfiguration#hsm_partition_name</a>.
        /// </summary>
        [<CustomOperation "hsm_partition_name">]
        member _.HsmPartitionName(state: RedshiftHsmConfigurationState<'Description, 'HsmConfigurationIdentifier, 'HsmIpAddress, Missing, 'HsmPartitionPassword, 'HsmServerPublicCertificate>, value: string) : RedshiftHsmConfigurationState<'Description, 'HsmConfigurationIdentifier, 'HsmIpAddress, Present, 'HsmPartitionPassword, 'HsmServerPublicCertificate> =
            state.assignments.Add(fun config -> config.HsmPartitionName <- value)
            ({ assignments = state.assignments } : RedshiftHsmConfigurationState<'Description, 'HsmConfigurationIdentifier, 'HsmIpAddress, Present, 'HsmPartitionPassword, 'HsmServerPublicCertificate>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_hsm_configuration#hsm_partition_password-1">RedshiftHsmConfiguration#hsm_partition_password</a>.
        /// </summary>
        [<CustomOperation "hsm_partition_password">]
        member _.HsmPartitionPassword(state: RedshiftHsmConfigurationState<'Description, 'HsmConfigurationIdentifier, 'HsmIpAddress, 'HsmPartitionName, Missing, 'HsmServerPublicCertificate>, value: string) : RedshiftHsmConfigurationState<'Description, 'HsmConfigurationIdentifier, 'HsmIpAddress, 'HsmPartitionName, Present, 'HsmServerPublicCertificate> =
            state.assignments.Add(fun config -> config.HsmPartitionPassword <- value)
            ({ assignments = state.assignments } : RedshiftHsmConfigurationState<'Description, 'HsmConfigurationIdentifier, 'HsmIpAddress, 'HsmPartitionName, Present, 'HsmServerPublicCertificate>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_hsm_configuration#hsm_server_public_certificate-1">RedshiftHsmConfiguration#hsm_server_public_certificate</a>.
        /// </summary>
        [<CustomOperation "hsm_server_public_certificate">]
        member _.HsmServerPublicCertificate(state: RedshiftHsmConfigurationState<'Description, 'HsmConfigurationIdentifier, 'HsmIpAddress, 'HsmPartitionName, 'HsmPartitionPassword, Missing>, value: string) : RedshiftHsmConfigurationState<'Description, 'HsmConfigurationIdentifier, 'HsmIpAddress, 'HsmPartitionName, 'HsmPartitionPassword, Present> =
            state.assignments.Add(fun config -> config.HsmServerPublicCertificate <- value)
            ({ assignments = state.assignments } : RedshiftHsmConfigurationState<'Description, 'HsmConfigurationIdentifier, 'HsmIpAddress, 'HsmPartitionName, 'HsmPartitionPassword, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_hsm_configuration#id-1">RedshiftHsmConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RedshiftHsmConfigurationState<'Description, 'HsmConfigurationIdentifier, 'HsmIpAddress, 'HsmPartitionName, 'HsmPartitionPassword, 'HsmServerPublicCertificate>, value: string) : RedshiftHsmConfigurationState<'Description, 'HsmConfigurationIdentifier, 'HsmIpAddress, 'HsmPartitionName, 'HsmPartitionPassword, 'HsmServerPublicCertificate> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RedshiftHsmConfigurationState<'Description, 'HsmConfigurationIdentifier, 'HsmIpAddress, 'HsmPartitionName, 'HsmPartitionPassword, 'HsmServerPublicCertificate>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_hsm_configuration#tags-1">RedshiftHsmConfiguration#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: RedshiftHsmConfigurationState<'Description, 'HsmConfigurationIdentifier, 'HsmIpAddress, 'HsmPartitionName, 'HsmPartitionPassword, 'HsmServerPublicCertificate>, value: seq<string * string>) : RedshiftHsmConfigurationState<'Description, 'HsmConfigurationIdentifier, 'HsmIpAddress, 'HsmPartitionName, 'HsmPartitionPassword, 'HsmServerPublicCertificate> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : RedshiftHsmConfigurationState<'Description, 'HsmConfigurationIdentifier, 'HsmIpAddress, 'HsmPartitionName, 'HsmPartitionPassword, 'HsmServerPublicCertificate>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_hsm_configuration#tags_all-1">RedshiftHsmConfiguration#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: RedshiftHsmConfigurationState<'Description, 'HsmConfigurationIdentifier, 'HsmIpAddress, 'HsmPartitionName, 'HsmPartitionPassword, 'HsmServerPublicCertificate>, value: seq<string * string>) : RedshiftHsmConfigurationState<'Description, 'HsmConfigurationIdentifier, 'HsmIpAddress, 'HsmPartitionName, 'HsmPartitionPassword, 'HsmServerPublicCertificate> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : RedshiftHsmConfigurationState<'Description, 'HsmConfigurationIdentifier, 'HsmIpAddress, 'HsmPartitionName, 'HsmPartitionPassword, 'HsmServerPublicCertificate>

        member _.Run(state: RedshiftHsmConfigurationState<Present, Present, Present, Present, Present, Present>) : aws.RedshiftHsmConfiguration.RedshiftHsmConfiguration =
            let config = aws.RedshiftHsmConfiguration.RedshiftHsmConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.RedshiftHsmConfiguration.RedshiftHsmConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.redshiftHsmConfiguration: missing required arguments. Must call: description, hsm_configuration_identifier, hsm_ip_address, hsm_partition_name, hsm_partition_password, hsm_server_public_certificate.", 9999, IsError = true)>]
        member _.Run(_: RedshiftHsmConfigurationState<_, _, _, _, _, _>) : aws.RedshiftHsmConfiguration.RedshiftHsmConfiguration =
            Unchecked.defaultof<aws.RedshiftHsmConfiguration.RedshiftHsmConfiguration>
