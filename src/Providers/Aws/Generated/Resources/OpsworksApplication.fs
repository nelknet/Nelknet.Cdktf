namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type OpsworksApplicationState<'Name, 'StackId, 'Type> = { assignments: ResizeArray<aws.OpsworksApplication.OpsworksApplicationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_application">aws_opsworks_application</a>.
    /// </summary>
    type OpsworksApplicationBuilder(logicalId: string) =
        member _.Yield(_: unit) : OpsworksApplicationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : OpsworksApplicationState<Missing, Missing, Missing>)

        member _.Zero(()) : OpsworksApplicationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : OpsworksApplicationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_application#name-1">OpsworksApplication#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: OpsworksApplicationState<Missing, 'StackId, 'Type>, value: string) : OpsworksApplicationState<Present, 'StackId, 'Type> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : OpsworksApplicationState<Present, 'StackId, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_application#stack_id-1">OpsworksApplication#stack_id</a>.
        /// </summary>
        [<CustomOperation "stack_id">]
        member _.StackId(state: OpsworksApplicationState<'Name, Missing, 'Type>, value: string) : OpsworksApplicationState<'Name, Present, 'Type> =
            state.assignments.Add(fun config -> config.StackId <- value)
            ({ assignments = state.assignments } : OpsworksApplicationState<'Name, Present, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_application#type-1">OpsworksApplication#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: OpsworksApplicationState<'Name, 'StackId, Missing>, value: string) : OpsworksApplicationState<'Name, 'StackId, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : OpsworksApplicationState<'Name, 'StackId, Present>)

        /// <summary>
        /// app_source block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_application#app_source-1">OpsworksApplication#app_source</a> Accepts: aws.IResolvable | aws.OpsworksApplication.OpsworksApplicationAppSource[]
        /// </summary>
        [<CustomOperation "app_source">]
        member _.AppSource(state: OpsworksApplicationState<'Name, 'StackId, 'Type>, value: HashiCorp.Cdktf.IResolvable) : OpsworksApplicationState<'Name, 'StackId, 'Type> =
            state.assignments.Add(fun config -> config.AppSource <- value)
            state : OpsworksApplicationState<'Name, 'StackId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_application#auto_bundle_on_deploy-1">OpsworksApplication#auto_bundle_on_deploy</a>.
        /// </summary>
        [<CustomOperation "auto_bundle_on_deploy">]
        member _.AutoBundleOnDeploy(state: OpsworksApplicationState<'Name, 'StackId, 'Type>, value: string) : OpsworksApplicationState<'Name, 'StackId, 'Type> =
            state.assignments.Add(fun config -> config.AutoBundleOnDeploy <- value)
            state : OpsworksApplicationState<'Name, 'StackId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_application#aws_flow_ruby_settings-1">OpsworksApplication#aws_flow_ruby_settings</a>.
        /// </summary>
        [<CustomOperation "aws_flow_ruby_settings">]
        member _.AwsFlowRubySettings(state: OpsworksApplicationState<'Name, 'StackId, 'Type>, value: string) : OpsworksApplicationState<'Name, 'StackId, 'Type> =
            state.assignments.Add(fun config -> config.AwsFlowRubySettings <- value)
            state : OpsworksApplicationState<'Name, 'StackId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_application#data_source_arn-1">OpsworksApplication#data_source_arn</a>.
        /// </summary>
        [<CustomOperation "data_source_arn">]
        member _.DataSourceArn(state: OpsworksApplicationState<'Name, 'StackId, 'Type>, value: string) : OpsworksApplicationState<'Name, 'StackId, 'Type> =
            state.assignments.Add(fun config -> config.DataSourceArn <- value)
            state : OpsworksApplicationState<'Name, 'StackId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_application#data_source_database_name-1">OpsworksApplication#data_source_database_name</a>.
        /// </summary>
        [<CustomOperation "data_source_database_name">]
        member _.DataSourceDatabaseName(state: OpsworksApplicationState<'Name, 'StackId, 'Type>, value: string) : OpsworksApplicationState<'Name, 'StackId, 'Type> =
            state.assignments.Add(fun config -> config.DataSourceDatabaseName <- value)
            state : OpsworksApplicationState<'Name, 'StackId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_application#data_source_type-1">OpsworksApplication#data_source_type</a>.
        /// </summary>
        [<CustomOperation "data_source_type">]
        member _.DataSourceType(state: OpsworksApplicationState<'Name, 'StackId, 'Type>, value: string) : OpsworksApplicationState<'Name, 'StackId, 'Type> =
            state.assignments.Add(fun config -> config.DataSourceType <- value)
            state : OpsworksApplicationState<'Name, 'StackId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_application#description-1">OpsworksApplication#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: OpsworksApplicationState<'Name, 'StackId, 'Type>, value: string) : OpsworksApplicationState<'Name, 'StackId, 'Type> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : OpsworksApplicationState<'Name, 'StackId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_application#document_root-1">OpsworksApplication#document_root</a>.
        /// </summary>
        [<CustomOperation "document_root">]
        member _.DocumentRoot(state: OpsworksApplicationState<'Name, 'StackId, 'Type>, value: string) : OpsworksApplicationState<'Name, 'StackId, 'Type> =
            state.assignments.Add(fun config -> config.DocumentRoot <- value)
            state : OpsworksApplicationState<'Name, 'StackId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_application#domains-1">OpsworksApplication#domains</a>.
        /// </summary>
        [<CustomOperation "domains">]
        member _.Domains(state: OpsworksApplicationState<'Name, 'StackId, 'Type>, value: seq<string>) : OpsworksApplicationState<'Name, 'StackId, 'Type> =
            state.assignments.Add(fun config -> config.Domains <- (value |> Seq.toArray))
            state : OpsworksApplicationState<'Name, 'StackId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_application#enable_ssl-1">OpsworksApplication#enable_ssl</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_ssl">]
        member _.EnableSsl(state: OpsworksApplicationState<'Name, 'StackId, 'Type>, value: bool) : OpsworksApplicationState<'Name, 'StackId, 'Type> =
            state.assignments.Add(fun config -> config.EnableSsl <- value)
            state : OpsworksApplicationState<'Name, 'StackId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_application#enable_ssl-1">OpsworksApplication#enable_ssl</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_ssl">]
        member _.EnableSsl(state: OpsworksApplicationState<'Name, 'StackId, 'Type>, value: HashiCorp.Cdktf.IResolvable) : OpsworksApplicationState<'Name, 'StackId, 'Type> =
            state.assignments.Add(fun config -> config.EnableSsl <- value)
            state : OpsworksApplicationState<'Name, 'StackId, 'Type>

        /// <summary>
        /// environment block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_application#environment-1">OpsworksApplication#environment</a> Accepts: aws.IResolvable | aws.OpsworksApplication.OpsworksApplicationEnvironment[]
        /// </summary>
        [<CustomOperation "environment">]
        member _.Environment(state: OpsworksApplicationState<'Name, 'StackId, 'Type>, value: HashiCorp.Cdktf.IResolvable) : OpsworksApplicationState<'Name, 'StackId, 'Type> =
            state.assignments.Add(fun config -> config.Environment <- value)
            state : OpsworksApplicationState<'Name, 'StackId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_application#id-1">OpsworksApplication#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: OpsworksApplicationState<'Name, 'StackId, 'Type>, value: string) : OpsworksApplicationState<'Name, 'StackId, 'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : OpsworksApplicationState<'Name, 'StackId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_application#rails_env-1">OpsworksApplication#rails_env</a>.
        /// </summary>
        [<CustomOperation "rails_env">]
        member _.RailsEnv(state: OpsworksApplicationState<'Name, 'StackId, 'Type>, value: string) : OpsworksApplicationState<'Name, 'StackId, 'Type> =
            state.assignments.Add(fun config -> config.RailsEnv <- value)
            state : OpsworksApplicationState<'Name, 'StackId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_application#short_name-1">OpsworksApplication#short_name</a>.
        /// </summary>
        [<CustomOperation "short_name">]
        member _.ShortName(state: OpsworksApplicationState<'Name, 'StackId, 'Type>, value: string) : OpsworksApplicationState<'Name, 'StackId, 'Type> =
            state.assignments.Add(fun config -> config.ShortName <- value)
            state : OpsworksApplicationState<'Name, 'StackId, 'Type>

        /// <summary>
        /// ssl_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_application#ssl_configuration-1">OpsworksApplication#ssl_configuration</a> Accepts: aws.IResolvable | aws.OpsworksApplication.OpsworksApplicationSslConfiguration[]
        /// </summary>
        [<CustomOperation "ssl_configuration">]
        member _.SslConfiguration(state: OpsworksApplicationState<'Name, 'StackId, 'Type>, value: HashiCorp.Cdktf.IResolvable) : OpsworksApplicationState<'Name, 'StackId, 'Type> =
            state.assignments.Add(fun config -> config.SslConfiguration <- value)
            state : OpsworksApplicationState<'Name, 'StackId, 'Type>

        member _.Run(state: OpsworksApplicationState<Present, Present, Present>) : aws.OpsworksApplication.OpsworksApplication =
            let config = aws.OpsworksApplication.OpsworksApplicationConfig()
            for setter in state.assignments do
                setter config
            aws.OpsworksApplication.OpsworksApplication(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.opsworksApplication: missing required arguments. Must call: name, stack_id, type.", 9999, IsError = true)>]
        member _.Run(_: OpsworksApplicationState<_, _, _>) : aws.OpsworksApplication.OpsworksApplication =
            Unchecked.defaultof<aws.OpsworksApplication.OpsworksApplication>
