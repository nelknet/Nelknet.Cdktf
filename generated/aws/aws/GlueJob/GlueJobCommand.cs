using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.glueJob.GlueJobCommand")]
    public class GlueJobCommand : aws.GlueJob.IGlueJobCommand
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_job#script_location GlueJob#script_location}.</summary>
        [JsiiProperty(name: "scriptLocation", typeJson: "{\"primitive\":\"string\"}")]
        public string ScriptLocation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_job#name GlueJob#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_job#python_version GlueJob#python_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pythonVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PythonVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_job#runtime GlueJob#runtime}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "runtime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Runtime
        {
            get;
            set;
        }
    }
}
