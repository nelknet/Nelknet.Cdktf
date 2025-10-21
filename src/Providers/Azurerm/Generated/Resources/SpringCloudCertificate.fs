namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SpringCloudCertificateState<'Name, 'ResourceGroupName, 'ServiceName> = { assignments: ResizeArray<azurerm.SpringCloudCertificate.SpringCloudCertificateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_certificate">azurerm_spring_cloud_certificate</a>.
    /// </summary>
    type SpringCloudCertificateBuilder(logicalId: string) =
        member _.Yield(_: unit) : SpringCloudCertificateState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudCertificateState<Missing, Missing, Missing>)

        member _.Zero(()) : SpringCloudCertificateState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudCertificateState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_certificate#name-1">SpringCloudCertificate#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SpringCloudCertificateState<Missing, 'ResourceGroupName, 'ServiceName>, value: string) : SpringCloudCertificateState<Present, 'ResourceGroupName, 'ServiceName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SpringCloudCertificateState<Present, 'ResourceGroupName, 'ServiceName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_certificate#resource_group_name-1">SpringCloudCertificate#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: SpringCloudCertificateState<'Name, Missing, 'ServiceName>, value: string) : SpringCloudCertificateState<'Name, Present, 'ServiceName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : SpringCloudCertificateState<'Name, Present, 'ServiceName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_certificate#service_name-1">SpringCloudCertificate#service_name</a>.
        /// </summary>
        [<CustomOperation "service_name">]
        member _.ServiceName(state: SpringCloudCertificateState<'Name, 'ResourceGroupName, Missing>, value: string) : SpringCloudCertificateState<'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.ServiceName <- value)
            ({ assignments = state.assignments } : SpringCloudCertificateState<'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_certificate#certificate_content-1">SpringCloudCertificate#certificate_content</a>.
        /// </summary>
        [<CustomOperation "certificate_content">]
        member _.CertificateContent(state: SpringCloudCertificateState<'Name, 'ResourceGroupName, 'ServiceName>, value: string) : SpringCloudCertificateState<'Name, 'ResourceGroupName, 'ServiceName> =
            state.assignments.Add(fun config -> config.CertificateContent <- value)
            state : SpringCloudCertificateState<'Name, 'ResourceGroupName, 'ServiceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_certificate#exclude_private_key-1">SpringCloudCertificate#exclude_private_key</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "exclude_private_key">]
        member _.ExcludePrivateKey(state: SpringCloudCertificateState<'Name, 'ResourceGroupName, 'ServiceName>, value: bool) : SpringCloudCertificateState<'Name, 'ResourceGroupName, 'ServiceName> =
            state.assignments.Add(fun config -> config.ExcludePrivateKey <- value)
            state : SpringCloudCertificateState<'Name, 'ResourceGroupName, 'ServiceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_certificate#exclude_private_key-1">SpringCloudCertificate#exclude_private_key</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "exclude_private_key">]
        member _.ExcludePrivateKey(state: SpringCloudCertificateState<'Name, 'ResourceGroupName, 'ServiceName>, value: HashiCorp.Cdktf.IResolvable) : SpringCloudCertificateState<'Name, 'ResourceGroupName, 'ServiceName> =
            state.assignments.Add(fun config -> config.ExcludePrivateKey <- value)
            state : SpringCloudCertificateState<'Name, 'ResourceGroupName, 'ServiceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_certificate#id-1">SpringCloudCertificate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SpringCloudCertificateState<'Name, 'ResourceGroupName, 'ServiceName>, value: string) : SpringCloudCertificateState<'Name, 'ResourceGroupName, 'ServiceName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SpringCloudCertificateState<'Name, 'ResourceGroupName, 'ServiceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_certificate#key_vault_certificate_id-1">SpringCloudCertificate#key_vault_certificate_id</a>.
        /// </summary>
        [<CustomOperation "key_vault_certificate_id">]
        member _.KeyVaultCertificateId(state: SpringCloudCertificateState<'Name, 'ResourceGroupName, 'ServiceName>, value: string) : SpringCloudCertificateState<'Name, 'ResourceGroupName, 'ServiceName> =
            state.assignments.Add(fun config -> config.KeyVaultCertificateId <- value)
            state : SpringCloudCertificateState<'Name, 'ResourceGroupName, 'ServiceName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_certificate#timeouts-1">SpringCloudCertificate#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SpringCloudCertificateState<'Name, 'ResourceGroupName, 'ServiceName>, value: azurerm.SpringCloudCertificate.SpringCloudCertificateTimeouts) : SpringCloudCertificateState<'Name, 'ResourceGroupName, 'ServiceName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SpringCloudCertificateState<'Name, 'ResourceGroupName, 'ServiceName>

        member _.Run(state: SpringCloudCertificateState<Present, Present, Present>) : azurerm.SpringCloudCertificate.SpringCloudCertificate =
            let config = azurerm.SpringCloudCertificate.SpringCloudCertificateConfig()
            for setter in state.assignments do
                setter config
            azurerm.SpringCloudCertificate.SpringCloudCertificate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.springCloudCertificate: missing required arguments. Must call: name, resource_group_name, service_name.", 9999, IsError = true)>]
        member _.Run(_: SpringCloudCertificateState<_, _, _>) : azurerm.SpringCloudCertificate.SpringCloudCertificate =
            Unchecked.defaultof<azurerm.SpringCloudCertificate.SpringCloudCertificate>
