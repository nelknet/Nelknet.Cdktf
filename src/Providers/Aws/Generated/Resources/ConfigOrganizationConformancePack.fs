namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ConfigOrganizationConformancePackState<'Name> = { assignments: ResizeArray<aws.ConfigOrganizationConformancePack.ConfigOrganizationConformancePackConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_conformance_pack">aws_config_organization_conformance_pack</a>.
    /// </summary>
    type ConfigOrganizationConformancePackBuilder(logicalId: string) =
        member _.Yield(_: unit) : ConfigOrganizationConformancePackState<Missing> =
            ({ assignments = ResizeArray() } : ConfigOrganizationConformancePackState<Missing>)

        member _.Zero(()) : ConfigOrganizationConformancePackState<Missing> =
            ({ assignments = ResizeArray() } : ConfigOrganizationConformancePackState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_conformance_pack#name-1">ConfigOrganizationConformancePack#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ConfigOrganizationConformancePackState<Missing>, value: string) : ConfigOrganizationConformancePackState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ConfigOrganizationConformancePackState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_conformance_pack#delivery_s3_bucket-1">ConfigOrganizationConformancePack#delivery_s3_bucket</a>.
        /// </summary>
        [<CustomOperation "delivery_s3_bucket">]
        member _.DeliveryS3Bucket(state: ConfigOrganizationConformancePackState<'Name>, value: string) : ConfigOrganizationConformancePackState<'Name> =
            state.assignments.Add(fun config -> config.DeliveryS3Bucket <- value)
            state : ConfigOrganizationConformancePackState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_conformance_pack#delivery_s3_key_prefix-1">ConfigOrganizationConformancePack#delivery_s3_key_prefix</a>.
        /// </summary>
        [<CustomOperation "delivery_s3_key_prefix">]
        member _.DeliveryS3KeyPrefix(state: ConfigOrganizationConformancePackState<'Name>, value: string) : ConfigOrganizationConformancePackState<'Name> =
            state.assignments.Add(fun config -> config.DeliveryS3KeyPrefix <- value)
            state : ConfigOrganizationConformancePackState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_conformance_pack#excluded_accounts-1">ConfigOrganizationConformancePack#excluded_accounts</a>.
        /// </summary>
        [<CustomOperation "excluded_accounts">]
        member _.ExcludedAccounts(state: ConfigOrganizationConformancePackState<'Name>, value: seq<string>) : ConfigOrganizationConformancePackState<'Name> =
            state.assignments.Add(fun config -> config.ExcludedAccounts <- (value |> Seq.toArray))
            state : ConfigOrganizationConformancePackState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_conformance_pack#id-1">ConfigOrganizationConformancePack#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ConfigOrganizationConformancePackState<'Name>, value: string) : ConfigOrganizationConformancePackState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ConfigOrganizationConformancePackState<'Name>

        /// <summary>
        /// input_parameter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_conformance_pack#input_parameter-1">ConfigOrganizationConformancePack#input_parameter</a> Accepts: aws.IResolvable | aws.ConfigOrganizationConformancePack.ConfigOrganizationConformancePackInputParameter[]
        /// </summary>
        [<CustomOperation "input_parameter">]
        member _.InputParameter(state: ConfigOrganizationConformancePackState<'Name>, value: HashiCorp.Cdktf.IResolvable) : ConfigOrganizationConformancePackState<'Name> =
            state.assignments.Add(fun config -> config.InputParameter <- value)
            state : ConfigOrganizationConformancePackState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_conformance_pack#template_body-1">ConfigOrganizationConformancePack#template_body</a>.
        /// </summary>
        [<CustomOperation "template_body">]
        member _.TemplateBody(state: ConfigOrganizationConformancePackState<'Name>, value: string) : ConfigOrganizationConformancePackState<'Name> =
            state.assignments.Add(fun config -> config.TemplateBody <- value)
            state : ConfigOrganizationConformancePackState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_conformance_pack#template_s3_uri-1">ConfigOrganizationConformancePack#template_s3_uri</a>.
        /// </summary>
        [<CustomOperation "template_s3_uri">]
        member _.TemplateS3Uri(state: ConfigOrganizationConformancePackState<'Name>, value: string) : ConfigOrganizationConformancePackState<'Name> =
            state.assignments.Add(fun config -> config.TemplateS3Uri <- value)
            state : ConfigOrganizationConformancePackState<'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_organization_conformance_pack#timeouts-1">ConfigOrganizationConformancePack#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ConfigOrganizationConformancePackState<'Name>, value: aws.ConfigOrganizationConformancePack.ConfigOrganizationConformancePackTimeouts) : ConfigOrganizationConformancePackState<'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ConfigOrganizationConformancePackState<'Name>

        member _.Run(state: ConfigOrganizationConformancePackState<Present>) : aws.ConfigOrganizationConformancePack.ConfigOrganizationConformancePack =
            let config = aws.ConfigOrganizationConformancePack.ConfigOrganizationConformancePackConfig()
            for setter in state.assignments do
                setter config
            aws.ConfigOrganizationConformancePack.ConfigOrganizationConformancePack(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.configOrganizationConformancePack: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: ConfigOrganizationConformancePackState<_>) : aws.ConfigOrganizationConformancePack.ConfigOrganizationConformancePack =
            Unchecked.defaultof<aws.ConfigOrganizationConformancePack.ConfigOrganizationConformancePack>
