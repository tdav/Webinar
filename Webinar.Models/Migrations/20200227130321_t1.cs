using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Aptex.Models.Migrations
{
    public partial class t1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sp_document_main_blocks",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    status = table.Column<int>(nullable: false),
                    create_date = table.Column<DateTime>(nullable: false),
                    update_date = table.Column<DateTime>(nullable: true),
                    create_user = table.Column<int>(nullable: false),
                    update_user = table.Column<int>(nullable: true),
                    site = table.Column<string>(maxLength: 100, nullable: false),
                    url = table.Column<string>(maxLength: 255, nullable: false),
                    css_class = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_document_main_blocks", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sp_key_phrases",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    status = table.Column<int>(nullable: false),
                    create_date = table.Column<DateTime>(nullable: false),
                    update_date = table.Column<DateTime>(nullable: true),
                    create_user = table.Column<int>(nullable: false),
                    update_user = table.Column<int>(nullable: true),
                    name = table.Column<string>(maxLength: 100, nullable: false),
                    description = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_key_phrases", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sp_languages",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    status = table.Column<int>(nullable: false),
                    create_date = table.Column<DateTime>(nullable: false),
                    update_date = table.Column<DateTime>(nullable: true),
                    create_user = table.Column<int>(nullable: false),
                    update_user = table.Column<int>(nullable: true),
                    name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_languages", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sp_news_categores",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    status = table.Column<int>(nullable: false),
                    create_date = table.Column<DateTime>(nullable: false),
                    update_date = table.Column<DateTime>(nullable: true),
                    create_user = table.Column<int>(nullable: false),
                    update_user = table.Column<int>(nullable: true),
                    main_id = table.Column<int>(nullable: false),
                    name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_news_categores", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sp_online_payments",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    status = table.Column<int>(nullable: false),
                    create_date = table.Column<DateTime>(nullable: false),
                    update_date = table.Column<DateTime>(nullable: true),
                    create_user = table.Column<int>(nullable: false),
                    update_user = table.Column<int>(nullable: true),
                    name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_online_payments", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_billings",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    status = table.Column<int>(nullable: false),
                    create_date = table.Column<DateTime>(nullable: false),
                    update_date = table.Column<DateTime>(nullable: true),
                    create_user = table.Column<int>(nullable: false),
                    update_user = table.Column<int>(nullable: true),
                    is_payed = table.Column<bool>(nullable: false),
                    balance_summa = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_billings", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_personal_categories",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    status = table.Column<int>(nullable: false),
                    create_date = table.Column<DateTime>(nullable: false),
                    update_date = table.Column<DateTime>(nullable: true),
                    create_user = table.Column<int>(nullable: false),
                    update_user = table.Column<int>(nullable: true),
                    title = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_personal_categories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_read_laters",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    status = table.Column<int>(nullable: false),
                    create_date = table.Column<DateTime>(nullable: false),
                    update_date = table.Column<DateTime>(nullable: true),
                    create_user = table.Column<int>(nullable: false),
                    update_user = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_read_laters", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_setups",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    status = table.Column<int>(nullable: false),
                    create_date = table.Column<DateTime>(nullable: false),
                    update_date = table.Column<DateTime>(nullable: true),
                    create_user = table.Column<int>(nullable: false),
                    update_user = table.Column<int>(nullable: true),
                    font_name = table.Column<string>(maxLength: 100, nullable: true),
                    font_size = table.Column<string>(maxLength: 100, nullable: true),
                    background = table.Column<string>(maxLength: 100, nullable: true),
                    text_color = table.Column<string>(maxLength: 100, nullable: true),
                    text_to_speech = table.Column<string>(maxLength: 100, nullable: true),
                    is_translate = table.Column<bool>(nullable: false),
                    translate_server = table.Column<string>(maxLength: 100, nullable: true),
                    translate_to_lang = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_setups", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_users",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    status = table.Column<int>(nullable: false),
                    create_date = table.Column<DateTime>(nullable: false),
                    update_date = table.Column<DateTime>(nullable: true),
                    create_user = table.Column<int>(nullable: false),
                    update_user = table.Column<int>(nullable: true),
                    first_name = table.Column<string>(maxLength: 100, nullable: true),
                    last_name = table.Column<string>(maxLength: 100, nullable: true),
                    username = table.Column<string>(maxLength: 20, nullable: false),
                    password = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_last_payments",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    status = table.Column<int>(nullable: false),
                    create_date = table.Column<DateTime>(nullable: false),
                    update_date = table.Column<DateTime>(nullable: true),
                    create_user = table.Column<int>(nullable: false),
                    update_user = table.Column<int>(nullable: true),
                    summa = table.Column<decimal>(nullable: false),
                    online_payment_id = table.Column<int>(nullable: false),
                    tb_billing_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_last_payments", x => x.id);
                    table.ForeignKey(
                        name: "fk_tb_last_payments_sp_online_payments_online_payment_id",
                        column: x => x.online_payment_id,
                        principalTable: "sp_online_payments",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_tb_last_payments_tb_billings_tb_billing_id",
                        column: x => x.tb_billing_id,
                        principalTable: "tb_billings",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_feeds",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    status = table.Column<int>(nullable: false),
                    create_date = table.Column<DateTime>(nullable: false),
                    update_date = table.Column<DateTime>(nullable: true),
                    create_user = table.Column<int>(nullable: false),
                    update_user = table.Column<int>(nullable: true),
                    title = table.Column<string>(nullable: true),
                    type = table.Column<string>(nullable: true),
                    icon_url = table.Column<string>(nullable: true),
                    html_url = table.Column<string>(nullable: true),
                    xml_url = table.Column<string>(nullable: true),
                    version = table.Column<string>(nullable: true),
                    language_id = table.Column<int>(nullable: true),
                    news_category_id = table.Column<int>(nullable: true),
                    personal_category_id = table.Column<int>(nullable: true),
                    v1 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_feeds", x => x.id);
                    table.ForeignKey(
                        name: "fk_tb_feeds_sp_languages_language_id",
                        column: x => x.language_id,
                        principalTable: "sp_languages",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_tb_feeds_tb_personal_categories_personal_category_id",
                        column: x => x.personal_category_id,
                        principalTable: "tb_personal_categories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_feed_items",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    status = table.Column<int>(nullable: false),
                    create_date = table.Column<DateTime>(nullable: false),
                    update_date = table.Column<DateTime>(nullable: true),
                    create_user = table.Column<int>(nullable: false),
                    update_user = table.Column<int>(nullable: true),
                    feed_id = table.Column<int>(nullable: false),
                    title = table.Column<string>(nullable: false),
                    author = table.Column<string>(maxLength: 100, nullable: true),
                    content = table.Column<string>(nullable: false),
                    publishing_date = table.Column<DateTime>(nullable: true),
                    url = table.Column<string>(maxLength: 255, nullable: false),
                    image_url = table.Column<string>(maxLength: 255, nullable: true),
                    last_updated = table.Column<DateTime>(nullable: true),
                    is_mark_as_read = table.Column<bool>(nullable: false),
                    tb_read_later_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_feed_items", x => x.id);
                    table.ForeignKey(
                        name: "fk_tb_feed_items_tb_feeds_feed_id",
                        column: x => x.feed_id,
                        principalTable: "tb_feeds",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_tb_feed_items_tb_read_laters_tb_read_later_id",
                        column: x => x.tb_read_later_id,
                        principalTable: "tb_read_laters",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_news_categories",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    status = table.Column<int>(nullable: false),
                    create_date = table.Column<DateTime>(nullable: false),
                    update_date = table.Column<DateTime>(nullable: true),
                    create_user = table.Column<int>(nullable: false),
                    update_user = table.Column<int>(nullable: true),
                    tb_feed_item_id = table.Column<int>(nullable: false),
                    news_category_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_news_categories", x => x.id);
                    table.ForeignKey(
                        name: "fk_tb_news_categories_sp_news_categores_news_category_id",
                        column: x => x.news_category_id,
                        principalTable: "sp_news_categores",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_tb_news_categories_tb_feed_items_tb_feed_item_id",
                        column: x => x.tb_feed_item_id,
                        principalTable: "tb_feed_items",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_recommendations",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    status = table.Column<int>(nullable: false),
                    create_date = table.Column<DateTime>(nullable: false),
                    update_date = table.Column<DateTime>(nullable: true),
                    create_user = table.Column<int>(nullable: false),
                    update_user = table.Column<int>(nullable: true),
                    label = table.Column<bool>(nullable: false),
                    score = table.Column<float>(nullable: false),
                    language_id = table.Column<int>(nullable: false),
                    news_category_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_recommendations", x => x.id);
                    table.ForeignKey(
                        name: "fk_tb_recommendations_sp_languages_language_id",
                        column: x => x.language_id,
                        principalTable: "sp_languages",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_tb_recommendations_tb_news_categories_news_category_id",
                        column: x => x.news_category_id,
                        principalTable: "tb_news_categories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_tb_feed_items_feed_id",
                table: "tb_feed_items",
                column: "feed_id");

            migrationBuilder.CreateIndex(
                name: "ix_tb_feed_items_tb_read_later_id",
                table: "tb_feed_items",
                column: "tb_read_later_id");

            migrationBuilder.CreateIndex(
                name: "ix_tb_feeds_language_id",
                table: "tb_feeds",
                column: "language_id");

            migrationBuilder.CreateIndex(
                name: "ix_tb_feeds_news_category_id",
                table: "tb_feeds",
                column: "news_category_id");

            migrationBuilder.CreateIndex(
                name: "ix_tb_feeds_personal_category_id",
                table: "tb_feeds",
                column: "personal_category_id");

            migrationBuilder.CreateIndex(
                name: "ix_tb_last_payments_online_payment_id",
                table: "tb_last_payments",
                column: "online_payment_id");

            migrationBuilder.CreateIndex(
                name: "ix_tb_last_payments_tb_billing_id",
                table: "tb_last_payments",
                column: "tb_billing_id");

            migrationBuilder.CreateIndex(
                name: "ix_tb_news_categories_news_category_id",
                table: "tb_news_categories",
                column: "news_category_id");

            migrationBuilder.CreateIndex(
                name: "ix_tb_news_categories_tb_feed_item_id",
                table: "tb_news_categories",
                column: "tb_feed_item_id");

            migrationBuilder.CreateIndex(
                name: "ix_tb_recommendations_language_id",
                table: "tb_recommendations",
                column: "language_id");

            migrationBuilder.CreateIndex(
                name: "ix_tb_recommendations_news_category_id",
                table: "tb_recommendations",
                column: "news_category_id");

            migrationBuilder.AddForeignKey(
                name: "fk_tb_feeds_tb_news_categories_news_category_id",
                table: "tb_feeds",
                column: "news_category_id",
                principalTable: "tb_news_categories",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_tb_feed_items_tb_feeds_feed_id",
                table: "tb_feed_items");

            migrationBuilder.DropTable(
                name: "sp_document_main_blocks");

            migrationBuilder.DropTable(
                name: "sp_key_phrases");

            migrationBuilder.DropTable(
                name: "tb_last_payments");

            migrationBuilder.DropTable(
                name: "tb_recommendations");

            migrationBuilder.DropTable(
                name: "tb_setups");

            migrationBuilder.DropTable(
                name: "tb_users");

            migrationBuilder.DropTable(
                name: "sp_online_payments");

            migrationBuilder.DropTable(
                name: "tb_billings");

            migrationBuilder.DropTable(
                name: "tb_feeds");

            migrationBuilder.DropTable(
                name: "sp_languages");

            migrationBuilder.DropTable(
                name: "tb_news_categories");

            migrationBuilder.DropTable(
                name: "tb_personal_categories");

            migrationBuilder.DropTable(
                name: "sp_news_categores");

            migrationBuilder.DropTable(
                name: "tb_feed_items");

            migrationBuilder.DropTable(
                name: "tb_read_laters");
        }
    }
}
