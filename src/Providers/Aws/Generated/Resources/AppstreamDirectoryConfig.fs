namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppstreamDirectoryConfigState<'DirectoryName, 'OrganizationalUnitDistinguishedNames, 'ServiceAccountCredentials> = { assignments: ResizeArray<aws.AppstreamDirectoryConfig.AppstreamDirectoryConfigConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_directory_config">aws_appstream_directory_config</a>.
    /// </summary>
    type AppstreamDirectoryConfigBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppstreamDirectoryConfigState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppstreamDirectoryConfigState<Missing, Missing, Missing>)

        member _.Zero(()) : AppstreamDirectoryConfigState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppstreamDirectoryConfigState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_directory_config#directory_name-1">AppstreamDirectoryConfig#directory_name</a>.
        /// </summary>
        [<CustomOperation "directory_name">]
        member _.DirectoryName(state: AppstreamDirectoryConfigState<Missing, 'OrganizationalUnitDistinguishedNames, 'ServiceAccountCredentials>, value: string) : AppstreamDirectoryConfigState<Present, 'OrganizationalUnitDistinguishedNames, 'ServiceAccountCredentials> =
            state.assignments.Add(fun config -> config.DirectoryName <- value)
            ({ assignments = state.assignments } : AppstreamDirectoryConfigState<Present, 'OrganizationalUnitDistinguishedNames, 'ServiceAccountCredentials>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_directory_config#organizational_unit_distinguished_names-1">AppstreamDirectoryConfig#organizational_unit_distinguished_names</a>.
        /// </summary>
        [<CustomOperation "organizational_unit_distinguished_names">]
        member _.OrganizationalUnitDistinguishedNames(state: AppstreamDirectoryConfigState<'DirectoryName, Missing, 'ServiceAccountCredentials>, value: seq<string>) : AppstreamDirectoryConfigState<'DirectoryName, Present, 'ServiceAccountCredentials> =
            state.assignments.Add(fun config -> config.OrganizationalUnitDistinguishedNames <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : AppstreamDirectoryConfigState<'DirectoryName, Present, 'ServiceAccountCredentials>)

        /// <summary>
        /// service_account_credentials block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_directory_config#service_account_credentials-1">AppstreamDirectoryConfig#service_account_credentials</a>
        /// </summary>
        [<CustomOperation "service_account_credentials">]
        member _.ServiceAccountCredentials(state: AppstreamDirectoryConfigState<'DirectoryName, 'OrganizationalUnitDistinguishedNames, Missing>, value: aws.AppstreamDirectoryConfig.AppstreamDirectoryConfigServiceAccountCredentials) : AppstreamDirectoryConfigState<'DirectoryName, 'OrganizationalUnitDistinguishedNames, Present> =
            state.assignments.Add(fun config -> config.ServiceAccountCredentials <- value)
            ({ assignments = state.assignments } : AppstreamDirectoryConfigState<'DirectoryName, 'OrganizationalUnitDistinguishedNames, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_directory_config#id-1">AppstreamDirectoryConfig#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppstreamDirectoryConfigState<'DirectoryName, 'OrganizationalUnitDistinguishedNames, 'ServiceAccountCredentials>, value: string) : AppstreamDirectoryConfigState<'DirectoryName, 'OrganizationalUnitDistinguishedNames, 'ServiceAccountCredentials> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppstreamDirectoryConfigState<'DirectoryName, 'OrganizationalUnitDistinguishedNames, 'ServiceAccountCredentials>

        member _.Run(state: AppstreamDirectoryConfigState<Present, Present, Present>) : aws.AppstreamDirectoryConfig.AppstreamDirectoryConfig =
            let config = aws.AppstreamDirectoryConfig.AppstreamDirectoryConfigConfig()
            for setter in state.assignments do
                setter config
            aws.AppstreamDirectoryConfig.AppstreamDirectoryConfig(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.appstreamDirectoryConfig: missing required arguments. Must call: directory_name, organizational_unit_distinguished_names, service_account_credentials.", 9999, IsError = true)>]
        member _.Run(_: AppstreamDirectoryConfigState<_, _, _>) : aws.AppstreamDirectoryConfig.AppstreamDirectoryConfig =
            Unchecked.defaultof<aws.AppstreamDirectoryConfig.AppstreamDirectoryConfig>
