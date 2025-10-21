namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ConfigConformancePackState<'Name> = { assignments: ResizeArray<aws.ConfigConformancePack.ConfigConformancePackConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_conformance_pack">aws_config_conformance_pack</a>.
    /// </summary>
    type ConfigConformancePackBuilder(logicalId: string) =
        member _.Yield(_: unit) : ConfigConformancePackState<Missing> =
            ({ assignments = ResizeArray() } : ConfigConformancePackState<Missing>)

        member _.Zero(()) : ConfigConformancePackState<Missing> =
            ({ assignments = ResizeArray() } : ConfigConformancePackState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_conformance_pack#name-1">ConfigConformancePack#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ConfigConformancePackState<Missing>, value: string) : ConfigConformancePackState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ConfigConformancePackState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_conformance_pack#delivery_s3_bucket-1">ConfigConformancePack#delivery_s3_bucket</a>.
        /// </summary>
        [<CustomOperation "delivery_s3_bucket">]
        member _.DeliveryS3Bucket(state: ConfigConformancePackState<'Name>, value: string) : ConfigConformancePackState<'Name> =
            state.assignments.Add(fun config -> config.DeliveryS3Bucket <- value)
            state : ConfigConformancePackState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_conformance_pack#delivery_s3_key_prefix-1">ConfigConformancePack#delivery_s3_key_prefix</a>.
        /// </summary>
        [<CustomOperation "delivery_s3_key_prefix">]
        member _.DeliveryS3KeyPrefix(state: ConfigConformancePackState<'Name>, value: string) : ConfigConformancePackState<'Name> =
            state.assignments.Add(fun config -> config.DeliveryS3KeyPrefix <- value)
            state : ConfigConformancePackState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_conformance_pack#id-1">ConfigConformancePack#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ConfigConformancePackState<'Name>, value: string) : ConfigConformancePackState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ConfigConformancePackState<'Name>

        /// <summary>
        /// input_parameter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_conformance_pack#input_parameter-1">ConfigConformancePack#input_parameter</a> Accepts: aws.IResolvable | aws.ConfigConformancePack.ConfigConformancePackInputParameter[]
        /// </summary>
        [<CustomOperation "input_parameter">]
        member _.InputParameter(state: ConfigConformancePackState<'Name>, value: HashiCorp.Cdktf.IResolvable) : ConfigConformancePackState<'Name> =
            state.assignments.Add(fun config -> config.InputParameter <- value)
            state : ConfigConformancePackState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_conformance_pack#template_body-1">ConfigConformancePack#template_body</a>.
        /// </summary>
        [<CustomOperation "template_body">]
        member _.TemplateBody(state: ConfigConformancePackState<'Name>, value: string) : ConfigConformancePackState<'Name> =
            state.assignments.Add(fun config -> config.TemplateBody <- value)
            state : ConfigConformancePackState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_conformance_pack#template_s3_uri-1">ConfigConformancePack#template_s3_uri</a>.
        /// </summary>
        [<CustomOperation "template_s3_uri">]
        member _.TemplateS3Uri(state: ConfigConformancePackState<'Name>, value: string) : ConfigConformancePackState<'Name> =
            state.assignments.Add(fun config -> config.TemplateS3Uri <- value)
            state : ConfigConformancePackState<'Name>

        member _.Run(state: ConfigConformancePackState<Present>) : aws.ConfigConformancePack.ConfigConformancePack =
            let config = aws.ConfigConformancePack.ConfigConformancePackConfig()
            for setter in state.assignments do
                setter config
            aws.ConfigConformancePack.ConfigConformancePack(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.configConformancePack: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: ConfigConformancePackState<_>) : aws.ConfigConformancePack.ConfigConformancePack =
            Unchecked.defaultof<aws.ConfigConformancePack.ConfigConformancePack>
