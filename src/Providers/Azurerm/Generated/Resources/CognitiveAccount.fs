namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName> = { assignments: ResizeArray<azurerm.CognitiveAccount.CognitiveAccountConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_account">azurerm_cognitive_account</a>.
    /// </summary>
    type CognitiveAccountBuilder(logicalId: string) =
        member _.Yield(_: unit) : CognitiveAccountState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CognitiveAccountState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : CognitiveAccountState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CognitiveAccountState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_account#kind-1">CognitiveAccount#kind</a>.
        /// </summary>
        [<CustomOperation "kind">]
        member _.Kind(state: CognitiveAccountState<Missing, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : CognitiveAccountState<Present, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Kind <- value)
            ({ assignments = state.assignments } : CognitiveAccountState<Present, 'Location, 'Name, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_account#location-1">CognitiveAccount#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: CognitiveAccountState<'Kind, Missing, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : CognitiveAccountState<'Kind, Present, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : CognitiveAccountState<'Kind, Present, 'Name, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_account#name-1">CognitiveAccount#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CognitiveAccountState<'Kind, 'Location, Missing, 'ResourceGroupName, 'SkuName>, value: string) : CognitiveAccountState<'Kind, 'Location, Present, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CognitiveAccountState<'Kind, 'Location, Present, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_account#resource_group_name-1">CognitiveAccount#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: CognitiveAccountState<'Kind, 'Location, 'Name, Missing, 'SkuName>, value: string) : CognitiveAccountState<'Kind, 'Location, 'Name, Present, 'SkuName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : CognitiveAccountState<'Kind, 'Location, 'Name, Present, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_account#sku_name-1">CognitiveAccount#sku_name</a>.
        /// </summary>
        [<CustomOperation "sku_name">]
        member _.SkuName(state: CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.SkuName <- value)
            ({ assignments = state.assignments } : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// customer_managed_key block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_account#customer_managed_key-1">CognitiveAccount#customer_managed_key</a>
        /// </summary>
        [<CustomOperation "customer_managed_key">]
        member _.CustomerManagedKey(state: CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: azurerm.CognitiveAccount.CognitiveAccountCustomerManagedKey) : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.CustomerManagedKey <- value)
            state : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_account#custom_question_answering_search_service_id-1">CognitiveAccount#custom_question_answering_search_service_id</a>.
        /// </summary>
        [<CustomOperation "custom_question_answering_search_service_id">]
        member _.CustomQuestionAnsweringSearchServiceId(state: CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.CustomQuestionAnsweringSearchServiceId <- value)
            state : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_account#custom_question_answering_search_service_key-1">CognitiveAccount#custom_question_answering_search_service_key</a>.
        /// </summary>
        [<CustomOperation "custom_question_answering_search_service_key">]
        member _.CustomQuestionAnsweringSearchServiceKey(state: CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.CustomQuestionAnsweringSearchServiceKey <- value)
            state : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_account#custom_subdomain_name-1">CognitiveAccount#custom_subdomain_name</a>.
        /// </summary>
        [<CustomOperation "custom_subdomain_name">]
        member _.CustomSubdomainName(state: CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.CustomSubdomainName <- value)
            state : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_account#dynamic_throttling_enabled-1">CognitiveAccount#dynamic_throttling_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "dynamic_throttling_enabled">]
        member _.DynamicThrottlingEnabled(state: CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: bool) : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.DynamicThrottlingEnabled <- value)
            state : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_account#dynamic_throttling_enabled-1">CognitiveAccount#dynamic_throttling_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "dynamic_throttling_enabled">]
        member _.DynamicThrottlingEnabled(state: CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: HashiCorp.Cdktf.IResolvable) : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.DynamicThrottlingEnabled <- value)
            state : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_account#fqdns-1">CognitiveAccount#fqdns</a>.
        /// </summary>
        [<CustomOperation "fqdns">]
        member _.Fqdns(state: CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: seq<string>) : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Fqdns <- (value |> Seq.toArray))
            state : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_account#id-1">CognitiveAccount#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_account#identity-1">CognitiveAccount#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: azurerm.CognitiveAccount.CognitiveAccountIdentity) : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_account#local_auth_enabled-1">CognitiveAccount#local_auth_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "local_auth_enabled">]
        member _.LocalAuthEnabled(state: CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: bool) : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.LocalAuthEnabled <- value)
            state : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_account#local_auth_enabled-1">CognitiveAccount#local_auth_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "local_auth_enabled">]
        member _.LocalAuthEnabled(state: CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: HashiCorp.Cdktf.IResolvable) : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.LocalAuthEnabled <- value)
            state : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_account#metrics_advisor_aad_client_id-1">CognitiveAccount#metrics_advisor_aad_client_id</a>.
        /// </summary>
        [<CustomOperation "metrics_advisor_aad_client_id">]
        member _.MetricsAdvisorAadClientId(state: CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.MetricsAdvisorAadClientId <- value)
            state : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_account#metrics_advisor_aad_tenant_id-1">CognitiveAccount#metrics_advisor_aad_tenant_id</a>.
        /// </summary>
        [<CustomOperation "metrics_advisor_aad_tenant_id">]
        member _.MetricsAdvisorAadTenantId(state: CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.MetricsAdvisorAadTenantId <- value)
            state : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_account#metrics_advisor_super_user_name-1">CognitiveAccount#metrics_advisor_super_user_name</a>.
        /// </summary>
        [<CustomOperation "metrics_advisor_super_user_name">]
        member _.MetricsAdvisorSuperUserName(state: CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.MetricsAdvisorSuperUserName <- value)
            state : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_account#metrics_advisor_website_name-1">CognitiveAccount#metrics_advisor_website_name</a>.
        /// </summary>
        [<CustomOperation "metrics_advisor_website_name">]
        member _.MetricsAdvisorWebsiteName(state: CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.MetricsAdvisorWebsiteName <- value)
            state : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// network_acls block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_account#network_acls-1">CognitiveAccount#network_acls</a>
        /// </summary>
        [<CustomOperation "network_acls">]
        member _.NetworkAcls(state: CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: azurerm.CognitiveAccount.CognitiveAccountNetworkAcls) : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.NetworkAcls <- value)
            state : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_account#outbound_network_access_restricted-1">CognitiveAccount#outbound_network_access_restricted</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "outbound_network_access_restricted">]
        member _.OutboundNetworkAccessRestricted(state: CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: bool) : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.OutboundNetworkAccessRestricted <- value)
            state : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_account#outbound_network_access_restricted-1">CognitiveAccount#outbound_network_access_restricted</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "outbound_network_access_restricted">]
        member _.OutboundNetworkAccessRestricted(state: CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: HashiCorp.Cdktf.IResolvable) : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.OutboundNetworkAccessRestricted <- value)
            state : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_account#public_network_access_enabled-1">CognitiveAccount#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: bool) : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_account#public_network_access_enabled-1">CognitiveAccount#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: HashiCorp.Cdktf.IResolvable) : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_account#qna_runtime_endpoint-1">CognitiveAccount#qna_runtime_endpoint</a>.
        /// </summary>
        [<CustomOperation "qna_runtime_endpoint">]
        member _.QnaRuntimeEndpoint(state: CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.QnaRuntimeEndpoint <- value)
            state : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// storage block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_account#storage-1">CognitiveAccount#storage</a> Accepts: azurerm.IResolvable | azurerm.CognitiveAccount.CognitiveAccountStorage[]
        /// </summary>
        [<CustomOperation "storage">]
        member _.Storage(state: CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: HashiCorp.Cdktf.IResolvable) : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Storage <- value)
            state : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_account#tags-1">CognitiveAccount#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: seq<string * string>) : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_account#timeouts-1">CognitiveAccount#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: azurerm.CognitiveAccount.CognitiveAccountTimeouts) : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CognitiveAccountState<'Kind, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        member _.Run(state: CognitiveAccountState<Present, Present, Present, Present, Present>) : azurerm.CognitiveAccount.CognitiveAccount =
            let config = azurerm.CognitiveAccount.CognitiveAccountConfig()
            for setter in state.assignments do
                setter config
            azurerm.CognitiveAccount.CognitiveAccount(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.cognitiveAccount: missing required arguments. Must call: kind, location, name, resource_group_name, sku_name.", 9999, IsError = true)>]
        member _.Run(_: CognitiveAccountState<_, _, _, _, _>) : azurerm.CognitiveAccount.CognitiveAccount =
            Unchecked.defaultof<azurerm.CognitiveAccount.CognitiveAccount>
