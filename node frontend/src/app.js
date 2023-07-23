import express from "express";
import { dirname, join } from "path";
import { fileURLToPath } from "url";

const app = express();
const port = 3000;

const __dirname = dirname(fileURLToPath(import.meta.url));

app.use(express.json());
app.use(express.urlencoded({ extended: true }));
app.use(express.static("public"));

app.set(`views`, join(__dirname, "views"));
app.set("view engine", "ejs");

// home path
app.get("/", (req, res) => {
  res.render("index");
});

app.post("/launch", (req, res) => {
  const rocketId = parseInt(req.body?.rocketId);   
  
  const rocketsAvailables = [1, 2, 3, 7];

  const rocketExists = rocketsAvailables.includes(rocketId);

  res.render("launch", { rocketExists });
});

// start server
app.listen(port, () => {
  console.log(`web serverworking on http://localhost:${port}`);
});
