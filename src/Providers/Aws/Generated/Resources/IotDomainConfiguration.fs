namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IotDomainConfigurationState<'Name> = { assignments: ResizeArray<aws.IotDomainConfiguration.IotDomainConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_domain_configuration">aws_iot_domain_configuration</a>.
    /// </summary>
    type IotDomainConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : IotDomainConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : IotDomainConfigurationState<Missing>)

        member _.Zero(()) : IotDomainConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : IotDomainConfigurationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_domain_configuration#name-1">IotDomainConfiguration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: IotDomainConfigurationState<Missing>, value: string) : IotDomainConfigurationState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : IotDomainConfigurationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_domain_configuration#application_protocol-1">IotDomainConfiguration#application_protocol</a>.
        /// </summary>
        [<CustomOperation "application_protocol">]
        member _.ApplicationProtocol(state: IotDomainConfigurationState<'Name>, value: string) : IotDomainConfigurationState<'Name> =
            state.assignments.Add(fun config -> config.ApplicationProtocol <- value)
            state : IotDomainConfigurationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_domain_configuration#authentication_type-1">IotDomainConfiguration#authentication_type</a>.
        /// </summary>
        [<CustomOperation "authentication_type">]
        member _.AuthenticationType(state: IotDomainConfigurationState<'Name>, value: string) : IotDomainConfigurationState<'Name> =
            state.assignments.Add(fun config -> config.AuthenticationType <- value)
            state : IotDomainConfigurationState<'Name>

        /// <summary>
        /// authorizer_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_domain_configuration#authorizer_config-1">IotDomainConfiguration#authorizer_config</a>
        /// </summary>
        [<CustomOperation "authorizer_config">]
        member _.AuthorizerConfig(state: IotDomainConfigurationState<'Name>, value: aws.IotDomainConfiguration.IotDomainConfigurationAuthorizerConfig) : IotDomainConfigurationState<'Name> =
            state.assignments.Add(fun config -> config.AuthorizerConfig <- value)
            state : IotDomainConfigurationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_domain_configuration#domain_name-1">IotDomainConfiguration#domain_name</a>.
        /// </summary>
        [<CustomOperation "domain_name">]
        member _.DomainName(state: IotDomainConfigurationState<'Name>, value: string) : IotDomainConfigurationState<'Name> =
            state.assignments.Add(fun config -> config.DomainName <- value)
            state : IotDomainConfigurationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_domain_configuration#id-1">IotDomainConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IotDomainConfigurationState<'Name>, value: string) : IotDomainConfigurationState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IotDomainConfigurationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_domain_configuration#server_certificate_arns-1">IotDomainConfiguration#server_certificate_arns</a>.
        /// </summary>
        [<CustomOperation "server_certificate_arns">]
        member _.ServerCertificateArns(state: IotDomainConfigurationState<'Name>, value: seq<string>) : IotDomainConfigurationState<'Name> =
            state.assignments.Add(fun config -> config.ServerCertificateArns <- (value |> Seq.toArray))
            state : IotDomainConfigurationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_domain_configuration#service_type-1">IotDomainConfiguration#service_type</a>.
        /// </summary>
        [<CustomOperation "service_type">]
        member _.ServiceType(state: IotDomainConfigurationState<'Name>, value: string) : IotDomainConfigurationState<'Name> =
            state.assignments.Add(fun config -> config.ServiceType <- value)
            state : IotDomainConfigurationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_domain_configuration#status-1">IotDomainConfiguration#status</a>.
        /// </summary>
        [<CustomOperation "status">]
        member _.Status(state: IotDomainConfigurationState<'Name>, value: string) : IotDomainConfigurationState<'Name> =
            state.assignments.Add(fun config -> config.Status <- value)
            state : IotDomainConfigurationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_domain_configuration#tags-1">IotDomainConfiguration#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: IotDomainConfigurationState<'Name>, value: seq<string * string>) : IotDomainConfigurationState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : IotDomainConfigurationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_domain_configuration#tags_all-1">IotDomainConfiguration#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: IotDomainConfigurationState<'Name>, value: seq<string * string>) : IotDomainConfigurationState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : IotDomainConfigurationState<'Name>

        /// <summary>
        /// tls_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_domain_configuration#tls_config-1">IotDomainConfiguration#tls_config</a>
        /// </summary>
        [<CustomOperation "tls_config">]
        member _.TlsConfig(state: IotDomainConfigurationState<'Name>, value: aws.IotDomainConfiguration.IotDomainConfigurationTlsConfig) : IotDomainConfigurationState<'Name> =
            state.assignments.Add(fun config -> config.TlsConfig <- value)
            state : IotDomainConfigurationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_domain_configuration#validation_certificate_arn-1">IotDomainConfiguration#validation_certificate_arn</a>.
        /// </summary>
        [<CustomOperation "validation_certificate_arn">]
        member _.ValidationCertificateArn(state: IotDomainConfigurationState<'Name>, value: string) : IotDomainConfigurationState<'Name> =
            state.assignments.Add(fun config -> config.ValidationCertificateArn <- value)
            state : IotDomainConfigurationState<'Name>

        member _.Run(state: IotDomainConfigurationState<Present>) : aws.IotDomainConfiguration.IotDomainConfiguration =
            let config = aws.IotDomainConfiguration.IotDomainConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.IotDomainConfiguration.IotDomainConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iotDomainConfiguration: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: IotDomainConfigurationState<_>) : aws.IotDomainConfiguration.IotDomainConfiguration =
            Unchecked.defaultof<aws.IotDomainConfiguration.IotDomainConfiguration>
