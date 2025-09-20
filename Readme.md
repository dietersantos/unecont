docker build -t unecont-frontend .
docker run -p 3000:3000 unecont-frontend
docker tag unecont-frontend:latest dietermarno/unecont-frontend:latest

docker build -t unecont-backend .
docker run -p 8080:8080 unecont-backend
docker tag unecont-backend:latest dietermarno/unecont-backend:latest

docker compose up -d
